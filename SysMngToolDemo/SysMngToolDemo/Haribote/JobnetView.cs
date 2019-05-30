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
            SetJobnetView();

        }

        public void SetJobnetView()
        {
            InitializeComponent();

            JobnetControl jobnetControl1 = new JobnetControl();
            jobnetControl1.JobnetId = "JOBNET_001";
            jobnetControl1.HeaderText = "JOBNET_001";
            jobnetControl1.ContentText = "売上登録";
            jobnetControl1.FooterText = "---";
            jobnetControl1.Location = new Point(92, 48);
            jobnetControl1.Size = new Size(98, 100);
            this.Controls.Add(jobnetControl1);

            JobnetControl jobnetControl2 = new JobnetControl();
            jobnetControl2.JobnetId = "JOBNET_002";
            jobnetControl2.HeaderText = "JOBNET_002";
            jobnetControl2.ContentText = "請求抽出";
            jobnetControl2.FooterText = "---";
            jobnetControl2.Location = new Point(327, 63);
            jobnetControl2.Size = new Size(98, 100);
            this.Controls.Add(jobnetControl2);

        }


    }
}
