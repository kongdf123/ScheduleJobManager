using DataAccess.DAL;
using DataAccess.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.DAL
{
    public class JobDetailDAL
    {
        public static JobDetailDAL CreateInstance() {
            return new JobDetailDAL();
        }

        public int Insert(JobDetail jobDetail) {
            jobDetail.UpdatedDate = DateTime.Now;
            jobDetail.CreatedDate = DateTime.Now;

            string sqlText = @"INSERT INTO custom_job_details
                            (`JobId`,
                            `JobName`,
                            `JobChineseName`,
                            `JobServiceURL`,
                            `CreatedDate`,
                            `UpdatedDate`,
                            `StartDate`,
                            `EndDate`,
                            `ExecutedFreq`,
                            `PageSize`,
                            `Interval`,
                            `State`,
                            `Description`,
                            `IntervalType`)
                            VALUES
                            (@JobId,
                            @JobName,
                            @JobChineseName,
                            @JobServiceURL,
                            @CreatedDate,
                            @UpdatedDate,
                            @StartDate,
                            @EndDate,
                            @ExecutedFreq,
                            @PageSize,
                            @Interval,
                            @State,
                            @Description,
                            @IntervalType); SELECT LAST_INSERT_ID();";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@JobId", MySqlDbType.Int32){ Value = jobDetail.JobId},
                new MySqlParameter("@JobName", MySqlDbType.VarChar , 100 ){ Value = jobDetail.JobName },
                new MySqlParameter("@JobChineseName", MySqlDbType.VarChar , 100 ){ Value = jobDetail.JobChineseName },
                new MySqlParameter("@JobServiceURL", MySqlDbType.VarChar , 200){ Value = jobDetail.JobServiceURL},
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = jobDetail.CreatedDate},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = jobDetail.UpdatedDate },
                new MySqlParameter("@StartDate", MySqlDbType.DateTime){ Value = jobDetail.StartDate},
                new MySqlParameter("@EndDate", MySqlDbType.DateTime){ Value = jobDetail.EndDate},
                new MySqlParameter("@PageSize", MySqlDbType.Int32){ Value = jobDetail.PageSize},
                new MySqlParameter("@Interval", MySqlDbType.Int32){ Value = jobDetail.Interval},
                new MySqlParameter("@IntervalType", MySqlDbType.Byte){ Value = jobDetail.IntervalType},
                new MySqlParameter("@State", MySqlDbType.Byte){ Value = jobDetail.State},
                new MySqlParameter("@Description", MySqlDbType.VarChar , 255){ Value = jobDetail.Description},
                new MySqlParameter("@ExecutedFreq", MySqlDbType.Byte){ Value = jobDetail.ExecutedFreq}
            };
            return MySqlDBHelper.ExecuteScalar<int>(sqlText, parameters);
        }

        public int Update(JobDetail jobDetail) {
            string sqlText = @"UPDATE custom_job_details
                                SET `JobName` = @JobName,
                                `JobChineseName` = @JobChineseName,
                                `JobServiceURL` = @JobServiceURL,
                                `CreatedDate` = @CreatedDate,
                                `UpdatedDate` = @UpdatedDate,
                                `StartDate` = @StartDate,
                                `EndDate` = @EndDate,
                                `PageSize` = @PageSize,
                                `Interval` = @Interval,
                                `IntervalType`=@IntervalType,
                                `State` = @State,
                                `Description` = @Description,
                                `ExecutedFreq`=@ExecutedFreq
                                WHERE `JobId` = @JobId AND `JobName` = @JobName;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@JobId", MySqlDbType.Int32 ){ Value = jobDetail.JobId },
                new MySqlParameter("@JobName", MySqlDbType.VarChar , 100 ){ Value = jobDetail.JobName },
                new MySqlParameter("@JobChineseName", MySqlDbType.VarChar , 100 ){ Value = jobDetail.JobChineseName },
                new MySqlParameter("@JobServiceURL", MySqlDbType.VarChar , 200){ Value = jobDetail.JobServiceURL},
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = jobDetail.CreatedDate},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = jobDetail.UpdatedDate },
                new MySqlParameter("@StartDate", MySqlDbType.DateTime){ Value = jobDetail.StartDate},
                new MySqlParameter("@EndDate", MySqlDbType.DateTime){ Value = jobDetail.EndDate},
                new MySqlParameter("@PageSize", MySqlDbType.Int32){ Value = jobDetail.PageSize},
                new MySqlParameter("@Interval", MySqlDbType.Int32){ Value = jobDetail.Interval},
                new MySqlParameter("@IntervalType", MySqlDbType.Byte){ Value = jobDetail.IntervalType},
                new MySqlParameter("@State", MySqlDbType.Byte){ Value = jobDetail.State},
                new MySqlParameter("@Description", MySqlDbType.VarChar , 255){ Value = jobDetail.Description},
                new MySqlParameter("@ExecutedFreq", MySqlDbType.Byte){ Value = jobDetail.ExecutedFreq}
            };
            return MySqlDBHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public int Delete(int jobId, string jobName) {
            string sqlText = "DELETE FROM custom_job_details WHERE JobId = @JobId AND JobName = @JobName;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@JobId" , MySqlDbType.Int32){ Value = jobId },
                new MySqlParameter("@JobName", MySqlDbType.VarChar , 100 ){ Value = jobName }
            };
            return MySqlDBHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public JobDetail Get(int jobId, string jobName) {
            JobDetail jobDetail = null;
            string sqlText = @" SELECT `custom_job_details`.`JobId`,
                                `custom_job_details`.`JobName`,
                                `custom_job_details`.`JobChineseName`,
                                `custom_job_details`.`JobServiceURL`,
                                `custom_job_details`.`CreatedDate`,
                                `custom_job_details`.`UpdatedDate`,
                                `custom_job_details`.`StartDate`,
                                `custom_job_details`.`EndDate`,
                                `custom_job_details`.`ExecutedFreq`,
                                `custom_job_details`.`PageSize`,
                                `custom_job_details`.`Interval`,
                                `custom_job_details`.`State`,
                                `custom_job_details`.`Description`,
                                `custom_job_details`.`IntervalType`
                            FROM `quartz`.`custom_job_details`
                            WHERE `custom_job_details`.`JobId` = @JobId AND `custom_job_details`.`JobName` = @JobName;";
            MySqlParameter[] parameters =
            {
                 new MySqlParameter("@JobId" , MySqlDbType.Int32){ Value = jobId },
                new MySqlParameter("@JobName", MySqlDbType.VarChar , 100 ){ Value = jobName }
            };

            MySqlDataReader sqlDataReader = MySqlDBHelper.ExecuteReader(sqlText, parameters);
            if ( sqlDataReader.Read() ) {
                jobDetail = new JobDetail();
                ReadRecordData(sqlDataReader, jobDetail);
            }
            sqlDataReader.Close();
            return jobDetail;
        }

        public PageData GetPageList(int pageSize, int curPage, string jobName = "") {
            string sqlWhere = "";
            List<MySqlParameter> listParms = new List<MySqlParameter>();
            if ( !string.IsNullOrEmpty(jobName) ) {
                sqlWhere = "WHERE JobName LIKE @JobName";
                listParms.Add(new MySqlParameter("@JobName", MySqlDbType.VarChar, 100) { Value = "%" + jobName + "%" });
            }

            int recordsTotal = MySqlDBHelper.ExecuteScalar<int>("SELECT COUNT(*) FROM custom_job_details " + sqlWhere, listParms.ToArray());

            string sqlText = @" SELECT JobId,
                                JobName,
                                JobChineseName,
                                JobServiceURL,
                                CreatedDate,
                                UpdatedDate,
                                StartDate,
                                EndDate,
                                PageSize,
                                `Interval`,
                                IntervalType,
                                State,
                                Description,
                                ExecutedFreq
                            FROM custom_job_details LIMIT " + (curPage - 1) + "," + pageSize + " " + sqlWhere;
            List<JobDetail> list = new List<JobDetail>();
            MySqlDataReader sqlDataReader = MySqlDBHelper.ExecuteReader(sqlText, listParms.ToArray());

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount =Math.Max(1,recordsTotal);
            if ( pageData.RecordCount > 0 ) {
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
            }

            while ( sqlDataReader.Read() ) {
                JobDetail jobDetail = new JobDetail();
                ReadRecordData(sqlDataReader, jobDetail);
                list.Add(jobDetail);
            }
            sqlDataReader.Close();
            pageData.PageList = list;
            return pageData;
        }

        void ReadRecordData(IDataReader dataReader, JobDetail jobDetail) {
            if ( dataReader["JobId"] != DBNull.Value )
                jobDetail.JobId = Convert.ToInt32(dataReader["JobId"]);

            if ( dataReader["JobName"] != DBNull.Value )
                jobDetail.JobName = Convert.ToString(dataReader["JobName"]);

            if ( dataReader["JobChineseName"] != DBNull.Value )
                jobDetail.JobChineseName = Convert.ToString(dataReader["JobChineseName"]);

            if ( dataReader["JobServiceURL"] != DBNull.Value )
                jobDetail.JobServiceURL = Convert.ToString(dataReader["JobServiceURL"]);

            if ( dataReader["CreatedDate"] != DBNull.Value )
                jobDetail.CreatedDate = Convert.ToDateTime(dataReader["CreatedDate"]);

            if ( dataReader["UpdatedDate"] != DBNull.Value )
                jobDetail.UpdatedDate = Convert.ToDateTime(dataReader["UpdatedDate"]);

            if ( dataReader["StartDate"] != DBNull.Value )
                jobDetail.StartDate = Convert.ToDateTime(dataReader["StartDate"]);

            if ( dataReader["EndDate"] != DBNull.Value )
                jobDetail.EndDate = Convert.ToDateTime(dataReader["EndDate"]);

            if ( dataReader["PageSize"] != DBNull.Value )
                jobDetail.PageSize = Convert.ToInt32(dataReader["PageSize"]);

            if ( dataReader["Interval"] != DBNull.Value )
                jobDetail.Interval = Convert.ToInt32(dataReader["Interval"]);

            if (dataReader["IntervalType"]!=DBNull.Value)
            {
                jobDetail.IntervalType = Convert.ToByte(dataReader["IntervalType"]);
            }

            if ( dataReader["State"] != DBNull.Value )
                jobDetail.State = Convert.ToByte(dataReader["State"]);

            if ( dataReader["Description"] != DBNull.Value )
                jobDetail.Description = Convert.ToString(dataReader["Description"]);
            
            if (dataReader["ExecutedFreq"] != DBNull.Value)
            {
                jobDetail.ExecutedFreq = Convert.ToByte(dataReader["ExecutedFreq"]);
            }
        }
    }
}
