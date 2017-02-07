using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop.ScheduleJob
{
    public partial class ScheduleJobListControl : UserControl
    {
        public ScheduleJobListControl() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateScheduleJob_Click(object sender, EventArgs e)
        {
            var jobEditForm = new frmJobEdit(); 
            jobEditForm.StartPosition = FormStartPosition.CenterParent;
            jobEditForm.ShowDialog(this);
        }

        private void ScheduleJobListControl_Resize(object sender, EventArgs e)
        {

        }
    }
}
