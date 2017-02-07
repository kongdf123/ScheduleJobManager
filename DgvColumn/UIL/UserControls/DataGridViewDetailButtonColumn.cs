using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BudStudio.DgvColumn.UIL
{
    /// <summary>
    /// 对象名称：DataGridView操作按钮列（查看详细）
    /// 对象说明：通过本类可以实现，在DataGridView控件中，显示一个名为“查看详细”图片按钮的列。
    /// 作者姓名：BudStudio 子水良（QQ：1541532664）
    /// 编写日期：2010/06/20 04:50:39
    /// </summary>
    public class DataGridViewDetailButtonColumn : DataGridViewColumn
    {
        public DataGridViewDetailButtonColumn()
        {
            this.CellTemplate = new DataGridViewDetailButtonCell();
            this.HeaderText = "操作";
        }
    }

    /// <summary>
    /// DataGridView操作按钮单元格，继承自DataGridViewButtonCell类。使用本自定义列或单元格前，请
    /// 确保应用程序的Properties.Resources资源文件中，包含了分别名为：BtnView、BtnView02的图片。
    /// </summary>
    public class DataGridViewDetailButtonCell : DataGridViewButtonCell
    {
        private bool mouseOnDetailButton = false; // 鼠标是否移动到查看详细按钮上
        private static Image ImageDetail = Properties.Resources.BtnView; // 查看详细按钮背景图片
        private static Pen penDetail = new Pen(Color.FromArgb(135, 163, 193)); // 查看详细按钮边框颜色
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
            if (mouseOnDetailButton) // 鼠标移动到查看详细按钮上，更换背景及边框颜色
            {
                ImageDetail = Properties.Resources.BtnView02;
                penDetail = new Pen(Color.FromArgb(162, 144, 77));
            }
            else
            {
                ImageDetail = Properties.Resources.BtnView;
                penDetail = new Pen(Color.FromArgb(135, 163, 193));
            }


            if (clearBackground) // 是否需要重绘单元格的背景颜色
            {
                Brush brushCellBack = (rowIndex == this.DataGridView.CurrentRow.Index) ? new SolidBrush(cellStyle.SelectionBackColor) : new SolidBrush(cellStyle.BackColor);
                graphics.FillRectangle(brushCellBack, cellBounds.X + 1, cellBounds.Y + 1, cellBounds.Width - 2, cellBounds.Height - 2);
            }

            Rectangle recDetail = new Rectangle(cellBounds.Location.X + (cellBounds.Width - ImageDetail.Width) / 2, cellBounds.Location.Y + (cellBounds.Height - ImageDetail.Height) / 2, ImageDetail.Width, ImageDetail.Height);

            graphics.DrawImage(ImageDetail, recDetail);
            graphics.DrawRectangle(penDetail, recDetail.X, recDetail.Y - 1, recDetail.Width, recDetail.Height);
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
            Rectangle recDetail = new Rectangle(cellBounds.Location.X + (cellBounds.Width - ImageDetail.Width) / 2, cellBounds.Location.Y + (cellBounds.Height - ImageDetail.Height) / 2, ImageDetail.Width, ImageDetail.Height);
            Rectangle paintCellBounds = DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            paintCellBounds.Width = DataGridView.Columns[nowColIndex].Width;
            paintCellBounds.Height = DataGridView.Rows[nowRowIndex].Height;

            if (IsInRect(e.X, e.Y, recDetail)) // 鼠标移动到查看详细按钮上
            {
                if (!mouseOnDetailButton)
                {
                    mouseOnDetailButton = true;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Hand;
                }
            }
            else
            {
                if (mouseOnDetailButton)
                {
                    mouseOnDetailButton = false;
                    PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, e.RowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                    DataGridView.Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// 鼠标从单元格内移出时的事件处理，调用私有的重绘方法进行重绘。
        /// </summary>
        protected override void OnMouseLeave(int rowIndex)
        {
            if (mouseOnDetailButton != false)
            {
                mouseOnDetailButton = false;

                Rectangle paintCellBounds = DataGridView.GetCellDisplayRectangle(nowColIndex, nowRowIndex, true);

                paintCellBounds.Width = DataGridView.Columns[nowColIndex].Width;
                paintCellBounds.Height = DataGridView.Rows[nowRowIndex].Height;

                PrivatePaint(this.DataGridView.CreateGraphics(), paintCellBounds, nowRowIndex, this.DataGridView.RowTemplate.DefaultCellStyle, false);
                DataGridView.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 判断用户是否单击了查看详细按钮，DataGridView发生CellMouseClick事件时，
        /// 因本单元格中有两个按钮，本方法通过坐标判断用户是否单击了查看详细按钮。
        /// </summary>
        public static bool IsDetailButtonClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView DgvGrid = (DataGridView)sender;
                if (DgvGrid.Columns[e.ColumnIndex] is DataGridViewDetailButtonColumn)
                {
                    Rectangle cellBounds = DgvGrid[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle recDetail = new Rectangle(cellBounds.Location.X + (cellBounds.Width - ImageDetail.Width) / 2, cellBounds.Location.Y + (cellBounds.Height - ImageDetail.Height) / 2, ImageDetail.Width, ImageDetail.Height);
                    if (IsInRect(e.X, e.Y, recDetail))
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
