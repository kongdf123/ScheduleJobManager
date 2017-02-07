using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BudStudio.DgvColumn.COL
{
    /// <summary>
    /// 对象名称：数据分页实体类（数据实体层）
    /// 对象说明：主要用于数据访问层与用户界面层中的PageBar分页控件进行数据交互。
    /// 作者姓名：爱英思躺（QQ：2415540409）
    /// 编写日期：2010/06/11 14:28:06
    /// </summary>
    public class PageData
    {
        /// <summary>
        /// [属性]分页过后的数据。
        /// </summary>
        public IList PageList
        {
            get;
            set;
        }

        /// <summary>
        /// [属性]每页显示记录数。
        /// </summary>
        public int PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// [属性]所请求的当前页数。
        /// </summary>
        public int CurPage
        {
            get;
            set;
        }

        /// <summary>
        /// [属性]总页数。
        /// </summary>
        public int PageCount
        {
            get;
            set;
        }

        /// <summary>
        /// [属性]总记录数。
        /// </summary>
        public int RecordCount
        {
            get;
            set;
        }

        /// <summary>
        /// [属性]相对于当前页的上一页
        /// </summary>
        public int PrevPage
        {
            get
            {
                if (CurPage > 1)
                {
                    return CurPage - 1;
                }
                return 1;
            }
        }

        /// <summary>
        /// [属性]相对于当前页的下一页
        /// </summary>
        public int NextPage
        {
            get
            {
                if (CurPage < PageCount)
                {
                    return CurPage + 1;
                }
                return PageCount;
            }
        }
    }
}
