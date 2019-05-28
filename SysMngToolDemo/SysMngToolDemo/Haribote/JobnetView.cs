using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo.Haribote
{
    public partial class JobnetView : Form
    {
        public JobnetView()
        {
            InitializeComponent();
            jobnetControl1.HeaderText = "JOBNET_001";
            jobnetControl1.ContentText = "○○○" + Environment.NewLine + "□□";
            jobnetControl1.FooterText = "---";
        }


    }
}
