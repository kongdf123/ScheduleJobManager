using ScheduleJobDesktop.ScheduleJob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop
{
    public partial class frmMain : Form
    {
        public frmMain() {
            InitializeComponent();
            lblDate.Text = "欢迎访问，今天是" + DateTime.Now.ToString("yyyy年MM月dd日");
        }

        private void linkScheduleJobList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (!tabContainer.Controls.ContainsKey("tabPageScheduleJobList") ) {
                TabPage tabScheduleJobList = new TabPage();
                tabScheduleJobList.Name = "tabPageScheduleJobList";
                tabScheduleJobList.Text = "任务列表";
                tabScheduleJobList.Controls.Add(new ScheduleJobListControl());

                tabContainer.Controls.Add(tabScheduleJobList);
                tabContainer.SelectTab("tabPageScheduleJobList");
            }
        }

        private void linkScheduleJobEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            
        }

        private void menuScheduleJob_Click(object sender, EventArgs e) {
            
        }


    }
}
