using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BudStudio.DgvColumn.COL
{
    /// <summary>
    /// 对象名称：部门信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    [Serializable]
    public class Department
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]自动编号</summary>
        private int? id;
        /// <summary>[变量]部门名称</summary>
        private string departmentName;
        /// <summary>[变量]经理姓名</summary>
        private string managerName;
        /// <summary>[变量]联系电话</summary>
        private string contactPhone;
        /// <summary>[变量]备注说明</summary>
        private string noteDescription;


        /// <summary>[属性]自动编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]部门名称</summary>
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        /// <summary>[属性]经理姓名</summary>
        public string ManagerName
        {
            get { return managerName; }
            set { managerName = value; }
        }
        /// <summary>[属性]联系电话</summary>
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        /// <summary>[属性]备注说明</summary>
        public string NoteDescription
        {
            get { return noteDescription; }
            set { noteDescription = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return DepartmentName;
        }

        #endregion EasyCode所生成的默认代码
    }
}
