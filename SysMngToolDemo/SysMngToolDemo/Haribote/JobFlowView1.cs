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
    public partial class JobFlowView1 : Form
    {
        public JobFlowView1()
        {
            InitializeComponent();
        }

        public void SetJobInfo(string jobId, string jobHeader, string jobContent, string jobFooter)
        {
            ((JobControl)this.Controls[jobId]).Controls["lblHeader"].Text = jobHeader;
            ((JobControl)this.Controls[jobId]).Controls["lblContent"].Text = jobContent;
            ((JobControl)this.Controls[jobId]).Controls["lblFooter"].Text = jobFooter;
        }

    }
}
