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
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void LineControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 20)
            {
                this.Height = 10;
                label1.Left = 1;
                label1.Top = 4;
                label1.Height = 2;
                label1.Width = this.Width - 2;
            }
            if (this.Height > 20)
            {
                this.Width = 10;
                label1.Left = 4;
                label1.Top = 1;
                label1.Width = 2;
                label1.Height = this.Height - 2;
            }
        }

        private void LineControl_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void LineContextMenuStrip_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
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
