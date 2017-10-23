using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using JobMonitor.Desktop.Properties;
using Service.BLL;
using Service.Model;
using JobMonitor.Utility;

namespace JobMonitor.Desktop.UI.ManageEventConfig
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
			var formSysMessage = FormSysMessage.ShowLoading();
			var filePath = TxtEventConfigFile.Text;
			if ( string.IsNullOrEmpty(filePath) || !File.Exists(filePath) ) {
				throw new CustomException("请输入上传文件存储地址！", ExceptionType.Warn);
			}
			List<EventDetail> listEventDetail = new List<EventDetail>();
			using ( var fileStream = new FileStream(filePath, FileMode.Open) ) {
				IWorkbook workbook = new XSSFWorkbook(fileStream);
				ISheet sheet = workbook.GetSheetAt(0);
				for ( int i = (sheet.FirstRowNum + 1); i < sheet.LastRowNum-1; i++ ) {
					IRow row = sheet.GetRow(i);
					EventDetail entity = new EventDetail();
					if ( string.IsNullOrEmpty(row.GetCell(0).ToString()) ||
						string.IsNullOrEmpty(row.GetCell(1).ToString()) ) {
						continue;
					}
					entity.EventId = row.GetCell(0).ToString();
					entity.EventName = row.GetCell(1).ToString();
					entity.EventDate = Convert.ToDateTime(row.GetCell(2).ToString());
					listEventDetail.Add(entity);
				}
			}
			if ( listEventDetail.Any() ) {
				EventDetailBLL.CreateInstance().Insert(listEventDetail);
			}
			formSysMessage.SetMessage("上传成功！");
			FormMain.LoadNewControl(EventConfigList.Instance); // 载入该模块的信息列表界面至主窗体显示。
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
