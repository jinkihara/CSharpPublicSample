using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo.Components
{
    public partial class ComponentBase : UserControl
    {
        public ComponentBase()
        {
            InitializeComponent();
        }

        private void ComponentBase_SizeChanged(object sender, EventArgs e)
        { 
            if (this.Height < HeaderLabel.Height + FooterLabel.Height)
            {
                this.Height = HeaderLabel.Height + FooterLabel.Height + 3;
            }
        }

        private void ComponentBase_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Cursor = Cursors.Hand;
        }

        private void HeaderLabel_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Cursor = Cursors.PanSouth;
        }

        private void ControlEdgeTable_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Cursor = Cursors.PanEast;
        }
    }
}
