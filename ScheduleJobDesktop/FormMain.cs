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
    public partial class FormMain : Form
    {
        public FormMain() {
            InitializeComponent();
            lblDate.Text = "欢迎访问，今天是" + DateTime.Now.ToString("yyyy年MM月dd日");

            int count = this.Controls.Count * 2 + 2;
            float[] factor = new float[count];
            int i = 0;
            factor[i++] = Size.Width;
            factor[i++] = Size.Height;
            foreach (Control ctrl in this.Controls)
            {
                factor[i++] = ctrl.Location.X / (float)Size.Width;
                factor[i++] = ctrl.Location.Y / (float)Size.Height;
                ctrl.Tag = ctrl.Size;//!!!
            }
            Tag = factor;
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
            var jobEditForm = new frmJobEdit(); 
            jobEditForm.StartPosition = FormStartPosition.CenterParent;
            jobEditForm.ShowDialog(this);
        }

        private void menuScheduleJob_Click(object sender, EventArgs e) {
            
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            float[] scale = (float[])Tag;
            int i = 2;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Left = (int)(Size.Width * scale[i++]);
                ctrl.Top = (int)(Size.Height * scale[i++]);
                ctrl.Width = (int)(Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);//!!!
                ctrl.Height = (int)(Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);//!!!
                 
            }
        }
    }
}
