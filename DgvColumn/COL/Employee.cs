using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BudStudio.DgvColumn.COL
{
    /// <summary>
    /// 对象名称：员工信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    [Serializable]
    public class Employee
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]自动编号</summary>
        private int? id;
        /// <summary>[变量]工号</summary>
        private string badgeId;
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]性别</summary>
        private Sex sex;
        /// <summary>[变量]出生日期</summary>
        private DateTime? dateOfBirth;
        /// <summary>[变量]身份证号</summary>
        private string iDCardId;
        /// <summary>[变量]民族</summary>
        private string nationa;
        /// <summary>[变量]政治面貌</summary>
        private string politicalLandscape;
        /// <summary>[变量]婚姻状况</summary>
        private string maritalStatus;
        /// <summary>[变量]户口所在地</summary>
        private string placeOfHouseholdRegistration;
        /// <summary>[变量]所在部门</summary>
        private Department department;
        /// <summary>[变量]现居住住址</summary>
        private string residenceAddress;
        /// <summary>[变量]毕业学校</summary>
        private string graduateSchool;
        /// <summary>[变量]所学专业</summary>
        private string fieldOfStudy;
        /// <summary>[变量]毕业时间</summary>
        private string graduationDate;
        /// <summary>[变量]学历</summary>
        private string academicQualifications;
        /// <summary>[变量]联系电话</summary>
        private string contactPhone;
        /// <summary>[变量]紧急联系人</summary>
        private string emergencyContacts;
        /// <summary>[变量]紧急电话</summary>
        private string emergencyTelephone;


        /// <summary>[属性]自动编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]工号</summary>
        public string BadgeId
        {
            get { return badgeId; }
            set { badgeId = value; }
        }
        /// <summary>[属性]姓名</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]性别</summary>
        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[属性]出生日期</summary>
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        /// <summary>[属性]身份证号</summary>
        public string IDCardId
        {
            get { return iDCardId; }
            set { iDCardId = value; }
        }
        /// <summary>[属性]民族</summary>
        public string Nationa
        {
            get { return nationa; }
            set { nationa = value; }
        }
        /// <summary>[属性]政治面貌</summary>
        public string PoliticalLandscape
        {
            get { return politicalLandscape; }
            set { politicalLandscape = value; }
        }
        /// <summary>[属性]婚姻状况</summary>
        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        /// <summary>[属性]户口所在地</summary>
        public string PlaceOfHouseholdRegistration
        {
            get { return placeOfHouseholdRegistration; }
            set { placeOfHouseholdRegistration = value; }
        }
        /// <summary>[属性]所在部门</summary>
        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        /// <summary>[属性]现居住住址</summary>
        public string ResidenceAddress
        {
            get { return residenceAddress; }
            set { residenceAddress = value; }
        }
        /// <summary>[属性]毕业学校</summary>
        public string GraduateSchool
        {
            get { return graduateSchool; }
            set { graduateSchool = value; }
        }
        /// <summary>[属性]所学专业</summary>
        public string FieldOfStudy
        {
            get { return fieldOfStudy; }
            set { fieldOfStudy = value; }
        }
        /// <summary>[属性]毕业时间</summary>
        public string GraduationDate
        {
            get { return graduationDate; }
            set { graduationDate = value; }
        }
        /// <summary>[属性]学历</summary>
        public string AcademicQualifications
        {
            get { return academicQualifications; }
            set { academicQualifications = value; }
        }
        /// <summary>[属性]联系电话</summary>
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        /// <summary>[属性]紧急联系人</summary>
        public string EmergencyContacts
        {
            get { return emergencyContacts; }
            set { emergencyContacts = value; }
        }
        /// <summary>[属性]紧急电话</summary>
        public string EmergencyTelephone
        {
            get { return emergencyTelephone; }
            set { emergencyTelephone = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
