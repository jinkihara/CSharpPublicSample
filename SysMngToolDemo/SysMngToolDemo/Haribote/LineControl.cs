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
        }

        private void LineControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 20) this.Height = 3;
            if (this.Height > 20) this.Width = 3;
        }

        private void LineControl_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
