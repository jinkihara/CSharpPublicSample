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
    public partial class LineControl : UserControl
    {
        public LineControl()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }

        private void LineControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 20)
            {
                this.Height = 4;
            }
            if (this.Height > 20)
            {
                this.Width = 4;
            }
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
        private void LineControl_MouseHover(object sender, EventArgs e)
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

        private void LineControl_MouseLeave(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Remove(l2);
            this.ParentForm.Controls.Remove(lbl);
        }

    }
}
