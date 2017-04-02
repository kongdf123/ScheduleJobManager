using System;
using System.IO;
using System.Windows.Forms;
using ScheduleJobDesktop.Properties;
using Utility;

namespace ScheduleJobDesktop.UI.ManageEventConfig
{
	public partial class EventConfigEdit : UserControl
	{
		static EventConfigEdit instance;

		/// <summary>
		/// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
		/// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
		/// </summary>
		public static EventConfigEdit Instance {
			get {
				if ( instance == null ) {
					instance = new EventConfigEdit();
				}
				return instance;
			}
		}

		/// <summary>
		/// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
		/// </summary>
		private EventConfigEdit() {
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// 用户单击“取消”按钮时的事件处理方法。
		/// </summary>
		private void BtnCancel_Click(object sender, EventArgs e) {
			FormMain.LoadNewControl(EventConfigList.Instance); // 载入该模块的信息列表界面至主窗体显示。
		}

		private void btnImportEventConfig_Click(object sender, EventArgs e) {
			//TODO
		}

		private void TxtEventConfigFile_Click(object sender, EventArgs e) {
			using ( var dialog = new OpenFileDialog() ) {
				dialog.Multiselect = false;
				dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
				var result = dialog.ShowDialog(this);
				if ( result == DialogResult.OK ) {
					TxtEventConfigFile.Text = dialog.FileName;
				}
			}
		}

		private void lblEventConfigTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			//Resources.EventConfigTemplate.
			string templatePath = Application.StartupPath + "\\EventConfigTemplate.xlsx";
			if ( !File.Exists(templatePath) ) {
				var bytes = Resources.EventConfigTemplate;
				using ( FileStream fsWrite = new FileStream(templatePath, FileMode.Create) ) {
					fsWrite.Write(bytes, 0, bytes.Length);
				};
			}
			System.Diagnostics.Process.Start(templatePath);
		}
	}
}
