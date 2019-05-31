using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo.Haribote
{
    public partial class MultiLineControl : UserControl
    {
        int lineWeight = 4;
        int lineMargin = 0;

        public MultiLineControl()
        {
            InitializeComponent();

            // 背景を透過させる設定
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void LineControl_Resize(object sender, EventArgs e)
        {
            lineStart.Width = lineWeight;
            lineStart.Height = (this.Height + lineWeight) / 2;

            lineHorizont.Height = lineWeight;
            lineHorizont.Top = (this.Height - lineWeight) / 2;
            lineHorizont.Width = this.Width - lineMargin * 2;

            lineEnd.Width = lineWeight;
            lineEnd.Top = lineHorizont.Top;
            lineEnd.Left = lineHorizont.Width - lineWeight + lineMargin;
            lineEnd.Height = lineStart.Height;

        }

        private void LineControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LineContextMenuStrip.Show();
                LineContextMenuStrip.Left = ((LineControl)sender).PointToScreen(e.Location).X;
                LineContextMenuStrip.Top = ((LineControl)sender).PointToScreen(e.Location).Y;
            }
        }

        private void LineContextMenuStrip_MouseUp(object sender, MouseEventArgs e)
        {

        }

        LineControl2 l2 = new LineControl2();
        Label lbl = new Label();
        private void ShowComments()
        {
            l2 = new LineControl2();
            l2.Name = "CommentLine";
            l2.Size = new Size(10, 60);
            l2.Location = new Point(this.ParentForm.PointToClient(Cursor.Position).X, this.ParentForm.PointToClient(Cursor.Position).Y - l2.Height);
            this.ParentForm.Controls.Add(l2);

            lbl = new Label();
            lbl.Name = "CommentLabel";
            lbl.Size = new Size(150, 30);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Location = new Point(l2.Left + l2.Width, l2.Top - lbl.Height);
            lbl.Text = "登録情報　：売上情報" + Environment.NewLine + "集計キー　：契約番号";
            this.ParentForm.Controls.Add(lbl);
        }
        private void HideComments()
        {
            this.ParentForm.Controls.Remove(l2);
            this.ParentForm.Controls.Remove(lbl);
        }

        private void lineHorizont_MouseMove(object sender, MouseEventArgs e)
        {
            Point clientMouseLocation = ((Label)sender).PointToClient(e.Location);
            
            if (((Label)sender).Width / 2 - 10 < clientMouseLocation.X && clientMouseLocation.X < ((Label)sender).Width / 2 + 10)
            {
                Cursor.Current = Cursors.SizeNS;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void lineStart_MouseHover(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Red);
            ShowComments();
        }

        private void lineStart_MouseLeave(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Black);
            HideComments();
        }

        private void lineHorizont_MouseHover(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Red);
        }

        private void lineHorizont_MouseLeave(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Black);
        }

        private void SetLineColor(object sender, Color lineColor)
        {
            this.BringToFront();
            this.BackColor = Color.Transparent;
            lineStart.BackColor = lineColor;
            lineHorizont.BackColor = lineColor;
            lineEnd.BackColor = lineColor;
        }

        private void lineEnd_MouseHover(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Red);
        }

        private void lineEnd_MouseLeave(object sender, EventArgs e)
        {
            SetLineColor(sender, Color.Black);
        }

        private void ShowContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LineContextMenuStrip.Show();
                LineContextMenuStrip.Left = ((Label)sender).PointToScreen(e.Location).X;
                LineContextMenuStrip.Top = ((Label)sender).PointToScreen(e.Location).Y;
            }

        }

    }
}
