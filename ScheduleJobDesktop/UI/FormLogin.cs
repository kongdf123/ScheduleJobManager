using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobMonitor.Desktop.UI
{
    public partial class FormLogin : Form
    {
        static FormLogin instance;

        /// <summary>
        /// 返回该窗体的唯一实例。如果之前该窗体没有被创建，进行创建并返回该窗体的唯一实例。
        /// 此处采用单键模式对窗体的唯一实例进行控制，以便外界窗体或控件可以随时访问本窗体。
        /// </summary>
        public static FormLogin Instance {
            get {
                if ( instance == null ) {
                    instance = new FormLogin();
                }
                return instance;
            }
        }
        public FormLogin() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            
        }

        private void btnReset_Click(object sender, EventArgs e) {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
