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
    public partial class JobControl : UserControl
    {
        public JobControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public string HeaderString
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        [Browsable(true)]
        public string ContentString
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }    
        }

        [Browsable(true)]
        public string FooterString
        {
            get { return lblFooter.Text; }
            set { lblFooter.Text = value; }
        }
    }
}
