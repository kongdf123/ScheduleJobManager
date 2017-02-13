using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop.UI.UserControls
{
    /// <summary>
    /// 自定义DataGridView操作按钮列（修改、删除）
    /// </summary>
    public class JobDataGridViewActionButtonColumn : DataGridViewColumn
    {
        public JobDataGridViewActionButtonColumn()
        {
            this.CellTemplate = new JobDataGridViewActionButtonCell();
            this.HeaderText = "操作";
        }
    }

    /// <summary>
    /// DataGridView操作按钮单元格，继承自DataGridViewButtonCell类。使用本自定义列或单元格前，请确保应用程序的
    /// </summary>
    public class JobDataGridViewActionButtonCell : DataGridViewButtonCell
    {
        private bool mouseOnModifyButton = false; // 鼠标是否移动到修改按钮上
        private bool mouseOnDeleteButton = false; // 鼠标是否移动到删除按钮上
        private bool mouseOnStartButton = false;  // 鼠标是否移动到启动按钮上
        private bool mouseOnStopButton = false;   // 鼠标是否移动到停止按钮上

        private static Image ImageModify = Properties.Resources.BtnModify; // 修改按钮背景图片
        private static Image ImageDelete = Properties.Resources.BtnDelete; // 删除按钮背景图片
        private static Image ImageStart = Properties.Resources.BtnStart;
        private static Image ImageStop = Properties.Resources.BtnStart;

        private static Pen penModify = new Pen(Color.FromArgb(135, 163, 193)); // 修改按钮边框颜色
        private static Pen penDelete = new Pen(Color.FromArgb(162, 144, 77));  // 删除按钮边框颜色
        private static Pen penStart = new Pen(Color.FromArgb(135, 163, 193)); //启动按钮边框颜色
        private static Pen penStop = new Pen(Color.FromArgb(135, 163, 193)); // 停止按钮边框颜色

        private static int nowColIndex = 0; // 当前列序号
        private static int nowRowIndex = 0; // 当前行序号

        /// <summary>
        /// 对单元格的重绘事件进行的方法重写。
        /// </summary>
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            cellBounds = PrivatePaint(graphics, cellBounds, rowIndex, cellStyle, true);
            base.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            nowColIndex = this.DataGridView.Columns.Count - 1;

        }

        /// <summary>
        /// 私有的单元格重绘方法，根据鼠标是否移动到按钮上，对按钮的不同背景和边框进行绘制。
        /// </summary>
        private Rectangle PrivatePaint(Graphics graphics, Rectangle cellBounds, int rowIndex, DataGridViewCellStyle cellStyle, bool clearBackground)
        {
            if (mouseOnModifyButton) // 鼠标移动到修改按钮上，更换背景及边框颜色
            {
                ImageModify = Properties.Resources.BtnModify02;
                penModify = new Pen(Color.FromArgb(162, 144, 77));
            }
            else
            {
                ImageModify = Properties.Resources.BtnModify;
                penModify = new Pen(Color.FromArgb(135, 163, 193));
            }

            if (mouseOnDeleteButton) // 鼠标移动到删除按钮上，更换背景及边框颜色
            {
                ImageDelete = Properties.Resources.BtnDelete02;
                penDelete = new Pen(Color.FromArgb(162, 144, 77));
            }
            else
            {
                ImageDelete = Properties.Resources.BtnDelete;
                penDelete = new Pen(Color.FromArgb(135, 163, 193));
            }

            byte jobState = Convert.ToByte(this.DataGridView["JobStateCode", rowIndex].Value.ToString()); // 获取所要设置的任务状态
            if (jobState == (byte)JobState.Running)
            {
                if (mouseOnStopButton) // 鼠标移动到修改按钮上，更换背景及边框颜色
                {
                    ImageStop = Properties.Resources.BtnStart;
                    penStop = new Pen(Color.FromArgb(162, 144, 77));
                }
                else
                {
                    ImageStop = Properties.Resources.BtnStart;
                    penStop = new Pen(Color.FromArgb(135, 163, 193));
                }
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                if (mouseOnStartButton) // 鼠标移动到修改按钮上，更换背景及边框颜色
                {
                    ImageStart = Properties.Resources.BtnStart;
                    penStart = new Pen(Color.FromArgb(162, 144, 77));
                }
                else
                {
                    ImageStart = Properties.Resources.BtnStart;
                    penStart = new Pen(Color.FromArgb(135, 163, 193));
                }
            }

            if (clearBackground) // 是否需要重绘单元格的背景颜色
            {
                Brush brushCellBack = (rowIndex == this.DataGridView.CurrentRow.Index) ? new SolidBrush(cellStyle.SelectionBackColor) : new SolidBrush(cellStyle.BackColor);
                graphics.FillRectangle(brushCellBack, cellBounds.X + 1, cellBounds.Y + 1, cellBounds.Width - 2, cellBounds.Height - 2);
            }

            Rectangle recModify = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 - ImageModify.Width - 2, cellBounds.Location.Y + (cellBounds.Height - ImageModify.Height) / 2, ImageModify.Width, ImageModify.Height);
            Rectangle recDelete = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageDelete.Height) / 2, ImageDelete.Width, ImageDelete.Height);

            Rectangle recStop=new Rectangle(),recStart=new Rectangle();
            if (jobState == (byte)JobState.Running)
            {
                recStop = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 50, cellBounds.Location.Y + (cellBounds.Height - ImageStop.Height) / 2, ImageStop.Width, ImageStop.Height); 
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                recStart = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 50, cellBounds.Location.Y + (cellBounds.Height - ImageStart.Height) / 2, ImageStart.Width, ImageStart.Height); 
            }
            graphics.DrawImage(ImageModify, recModify);
            graphics.DrawImage(ImageDelete, recDelete);
            if (jobState == (byte)JobState.Running)
            {
                graphics.DrawImage(ImageStop, recStop);
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                graphics.DrawImage(ImageStart, recStart);
            }

            graphics.DrawRectangle(penModify, recModify.X, recModify.Y - 1, recModify.Width, recModify.Height);
            graphics.DrawRectangle(penDelete, recDelete.X, recDelete.Y - 1, recDelete.Width, recDelete.Height);

            if (jobState == (byte)JobState.Running)
            {
                graphics.DrawRectangle(penStop, recStop.X, recStop.Y - 1, recStop.Width, recStop.Height);
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                graphics.DrawRectangle(penStart, recStart.X, recStart.Y - 1, recStart.Width, recStart.Height);
            }
            return cellBounds;
        }

        /// <summary>
        /// 鼠标移动到单元格内时的事件处理，通过坐标判断鼠标是否移动到了修改或删除按钮上，并调用私有的重绘方法进行重绘。
        /// </summary>
        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
        {
            if (base.DataGridView == null) return;

            nowColIndex = e.ColumnIndex;
            nowRowIndex = e.RowIndex;

            Rectangle cellBounds = DataGridView[e.ColumnIndex, e.RowIndex].ContentBounds;
            Rectangle recModify = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 - ImageModify.Width - 2, cellBounds.Location.Y + (cellBounds.Height - ImageModify.Height) / 2, ImageModify.Width, ImageModify.Height);
            Rectangle recDelete = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageDelete.Height) / 2, ImageDelete.Width, ImageDelete.Height);

            byte jobState = Convert.ToByte(this.DataGridView["JobStateCode", e.RowIndex].Value.ToString()); // 获取所要设置的任务状态
            Rectangle recStop = new Rectangle(), recStart = new Rectangle();
            if (jobState == (byte)JobState.Running)
            {
                recStop = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageStop.Height) / 2, ImageStop.Width, ImageStop.Height);
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                recStart = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageStart.Height) / 2, ImageStart.Width, ImageStart.Height);
            }
            Rectangle paintCellBounds = DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            paintCellBounds.Width = DataGridView.Columns[nowColIndex].Width;
            paintCellBounds.Height = DataGridView.Rows[nowRowIndex].Height;

            if (IsInRect(e.X, e.Y, recModify)) // 鼠标移动到修改按钮上
            {
                if (!mouseOnModifyButton)
                {
                    mouseOnModifyButton = true;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Hand;
                }
            }
            else
            {
                if (mouseOnModifyButton)
                {
                    mouseOnModifyButton = false;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Default;
                }
            }


            if (IsInRect(e.X, e.Y, recDelete)) // 鼠标移动到删除按钮上
            {
                if (!mouseOnDeleteButton)
                {
                    mouseOnDeleteButton = true;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Hand;
                }
            }
            else
            {
                if (mouseOnDeleteButton)
                {
                    mouseOnDeleteButton = false;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Default;
                }
            }

            if (jobState == (byte)JobState.Running)
            {
                if (IsInRect(e.X, e.Y, recStop)) // 鼠标移动到停止按钮上
                {
                    if (!mouseOnStopButton)
                    {
                        mouseOnStopButton = true;
                        PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                        DataGridView.Cursor = Cursors.Hand;
                    }
                }
                else
                {
                    if (mouseOnStopButton)
                    {
                        mouseOnStopButton = false;
                        PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                        DataGridView.Cursor = Cursors.Default;
                    }
                }
            }
            else if (jobState == (byte)JobState.Stopping || jobState == (byte)JobState.Waiting)
            {
                if (IsInRect(e.X, e.Y, recStart)) // 鼠标移动到启动按钮上
                {
                    if (!mouseOnStartButton)
                    {
                        mouseOnStartButton = true;
                        PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                        DataGridView.Cursor = Cursors.Hand;
                    }
                }
                else
                {
                    if (mouseOnStartButton)
                    {
                        mouseOnStartButton = false;
                        PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                        DataGridView.Cursor = Cursors.Default;
                    }
                }
            }
        }

        /// <summary>
        /// 鼠标从单元格内移出时的事件处理，调用私有的重绘方法进行重绘。
        /// </summary>
        protected override void OnMouseLeave(int rowIndex)
        {
            if (!mouseOnModifyButton || !mouseOnDeleteButton || !mouseOnStartButton || !mouseOnStopButton)
            {
                mouseOnModifyButton = false;
                mouseOnDeleteButton = false;
                mouseOnStartButton = false;
                mouseOnStopButton = false;

                Rectangle paintCellBounds = DataGridView.GetCellDisplayRectangle(nowColIndex, nowRowIndex, true);

                paintCellBounds.Width = DataGridView.Columns[nowColIndex].Width;
                paintCellBounds.Height = DataGridView.Rows[nowRowIndex].Height;

                PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, nowRowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                DataGridView.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 判断用户是否单击了修改按钮，DataGridView发生CellMouseClick事件时，
        /// 因本单元格中有两个按钮，本方法通过坐标判断用户是否单击了修改按钮。
        /// </summary>
        public static bool IsModifyButtonClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView DgvGrid = (DataGridView)sender;
                if (DgvGrid.Columns[e.ColumnIndex] is JobDataGridViewActionButtonColumn)
                {
                    Rectangle cellBounds = DgvGrid[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle recModify = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 - ImageModify.Width - 2, cellBounds.Location.Y + (cellBounds.Height - ImageModify.Height) / 2, ImageModify.Width, ImageModify.Height);
                    if (IsInRect(e.X, e.Y, recModify))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断用户是否单击了删除按钮，DataGridView发生CellMouseClick事件时，
        /// 因本单元格中有两个按钮，本方法通过坐标判断用户是否单击了删除按钮。
        /// </summary>
        public static bool IsDeleteButtonClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView DgvGrid = (DataGridView)sender;
                if (DgvGrid.Columns[e.ColumnIndex] is JobDataGridViewActionButtonColumn)
                {
                    Rectangle cellBounds = DgvGrid[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle recDelete = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageDelete.Height) / 2, ImageDelete.Width, ImageDelete.Height);
                    if (IsInRect(e.X, e.Y, recDelete))
                        return true;
                }
            }
            return false;
        }

        public static bool IsStartButtonClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView DgvGrid = (DataGridView)sender;
                if (DgvGrid.Columns[e.ColumnIndex] is JobDataGridViewActionButtonColumn)
                {
                    Rectangle cellBounds = DgvGrid[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle recStart = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageStart.Height) / 2, ImageStart.Width, ImageStart.Height);
                    if (IsInRect(e.X, e.Y, recStart))
                        return true;
                }
            }
            return false;
        }


        public static bool IsStopButtonClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView DgvGrid = (DataGridView)sender;
                if (DgvGrid.Columns[e.ColumnIndex] is JobDataGridViewActionButtonColumn)
                {
                    Rectangle cellBounds = DgvGrid[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle recStop = new Rectangle(cellBounds.Location.X + cellBounds.Width / 2 + 2, cellBounds.Location.Y + (cellBounds.Height - ImageStop.Height) / 2, ImageStop.Width, ImageStop.Height);
                    if (IsInRect(e.X, e.Y, recStop))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断鼠标坐标是否在指定的区域内。
        /// </summary>
        private static bool IsInRect(int x, int y, Rectangle area)
        {
            if (x > area.Left && x < area.Right && y > area.Top && y < area.Bottom)
                return true;
            return false;

        }

    }
}
