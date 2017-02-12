using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.DAL
{
    public class PageData
    {
        /// <summary>
        /// [属性]分页过后的数据。
        /// </summary>
        public IList PageList {
            get;
            set;
        }

        /// <summary>
        /// [属性]每页显示记录数。
        /// </summary>
        public int PageSize {
            get;
            set;
        }

        /// <summary>
        /// [属性]所请求的当前页数。
        /// </summary>
        public int CurPage {
            get;
            set;
        }

        /// <summary>
        /// [属性]总页数。
        /// </summary>
        public int PageCount {
            get;
            set;
        }

        /// <summary>
        /// [属性]总记录数。
        /// </summary>
        public int RecordCount {
            get;
            set;
        }

        /// <summary>
        /// [属性]相对于当前页的上一页
        /// </summary>
        public int PrevPage {
            get {
                if ( CurPage > 1 ) {
                    return CurPage - 1;
                }
                return 1;
            }
        }

        /// <summary>
        /// [属性]相对于当前页的下一页
        /// </summary>
        public int NextPage {
            get {
                if ( CurPage < PageCount ) {
                    return CurPage + 1;
                }
                return PageCount;
            }
        }
    }
}
