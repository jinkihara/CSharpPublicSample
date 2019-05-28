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
    public partial class JobnetControl : UserControl
    {
        public JobnetControl()
        {
            InitializeComponent();
        }

        // ヘッダテキスト
        public string HeaderText
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        // コンテンツテキスト
        public string ContentText
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }

        // フッタテキスト
        public string FooterText
        {
            get { return lblFooter.Text; }
            set { lblFooter.Text = value; }
        }

        // コンテキストメニュー Job01クリック
        private void job01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobFlowView win = new JobFlowView();
            win.Text = "Job01";
            win.SetJobInfo("Job11", "JOB_11", "開始処理", "---");
            win.SetJobInfo("Job12", "JOB_12", "契約処理", "---");
            win.SetJobInfo("Job13", "JOB_13", "顧客処理", "---");
            win.SetJobInfo("Job14", "JOB_14", "集計処理", "---");
            win.Show();
        }

        // ヘッダマウスアップ
        private void lblHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { 
                this.JobnetContextMenuStrip.Show();
                this.JobnetContextMenuStrip.Left = this.ParentForm.Location.X + this.Left + e.Location.X;
                this.JobnetContextMenuStrip.Top = this.ParentForm.Location.Y + this.Top + e.Location.Y;
            }
        }

        private void job02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobFlowView2 win = new JobFlowView2();
            win.Text = "Job02";
            win.SetJobInfo("Job11", "JOB_21", "開始処理", "---");
            win.SetJobInfo("Job12", "JOB_22", "契約処理", "---");
            win.SetJobInfo("Job13", "JOB_23", "終了処理", "---");
            win.SetJobInfo("Job14", "JOB_24", "連携処理", "---");
            win.Show();
        }

    }
}
