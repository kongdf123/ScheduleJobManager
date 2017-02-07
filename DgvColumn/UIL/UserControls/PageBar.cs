using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.UIL.UserControls
{
    /// <summary>
    /// 对象名称：数据分页用户控件
    /// 对象说明：采用DataReader进行高效数据分页，通过关联Repeater、DataGrid或DataList控件进行数据显示。
    /// 作者姓名：爱英思躺（QQ：2415540409）
    /// 编写日期：2010/06/15 21:40:49
    public partial class PageBar : UserControl
    {
        public event EventHandler PageChanged; //事件：控件的当前页码发生变更。
 
        /// <summary>
        /// PageBar分页控件所关联的DataGridView数据控件，当PageBar分页控件执行DataBind()数据绑定
        /// 方法时，PageBar分页控件会自动将分页后的数据，绑定给关联的DataGridView控件进行显示。
        /// </summary>
        public DataGridView DataControl
        {
            get;
            set;
        }

        /// <summary>
        /// PageBar分页控件的数据源，数据源为数据实体层中所定义的PageData类型。
        /// </summary>
        public PageData DataSource
        {
            get;
            set;
        }


        /// <summary>
        /// 控件实例化方法
        /// </summary>
        public PageBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 进行数据绑定，将数据源中的IList类型数据，绑定给关联的数据控件进行显示。
        /// </summary>
        public void DataBind()
        {
            if (DataSource == null) return;
            if (DataSource.CurPage > DataSource.PageCount)  //如果所请求的当前页大于数据源的总页数，转向到最后1页。
            {
                CurPage = DataSource.PageCount;
            }

            LblTotalRecord.Text = "总记录数：" + DataSource.RecordCount.ToString() + "条（" + DataSource.PageSize.ToString() + "条/页）";
            LblCurPage.Text = DataSource.CurPage.ToString() + "/" + DataSource.PageCount.ToString();
            TextJumpPage.Text = DataSource.CurPage.ToString();

            DataControl.AutoGenerateColumns = false;
            DataControl.DataSource = DataSource.PageList;
        }

        /// <summary>
        /// 用户单击“第一页”按钮时的事件处理方法。
        /// </summary>
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            CurPage = 1;
        }

        /// <summary>
        /// 用户单击“前一页”按钮时的事件处理方法。
        /// </summary>
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            CurPage = DataSource.PrevPage;
        }

        /// <summary>
        /// 用户单击“下一页”按钮时的事件处理方法。
        /// </summary>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            CurPage = DataSource.NextPage;
        }

        /// <summary>
        /// 用户单击“最后一页”按钮时的事件处理方法。
        /// </summary>
        private void BtnLast_Click(object sender, EventArgs e)
        {
            CurPage = DataSource.PageCount;
        }

        /// <summary>
        /// 用户单击“跳转”按钮时的事件处理方法。
        /// </summary>
        private void BtnGO_Click(object sender, EventArgs e)
        {
            int page = DataValid.GetIntOrZero(TextJumpPage.Text);
            if (page > 0)
                CurPage = page;
            else
                CurPage = 1;
        }

        #region PageBar控件的相关变量及属性定义

        private int pageSize;
        private int curPage;

        /// <summary>
        /// 每页显示记录数。
        /// </summary>
        public int PageSize
        {
            get
            {
                if (pageSize <= 0)
                {
                    pageSize = 15;
                }
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int CurPage
        {
            get
            {
                if (curPage <= 0)
                {
                    curPage = 1;
                }
                return curPage;
            }
            set
            {
                curPage = value;
                if (PageChanged != null)
                {
                    PageChanged(this, null);//触发当件页码变更事件。
                }

            }
        }


        #endregion
    }
}
