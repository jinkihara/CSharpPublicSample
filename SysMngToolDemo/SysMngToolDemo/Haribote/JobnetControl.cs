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
        private string jobnetId = "";

        public JobnetControl()
        {
            InitializeComponent();
            jobListToolStripMenuItem.Tag = "XYZ";
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
            win.Text = ((ToolStripMenuItem)sender).Text; ;
            win.SetJobInfo("Job11", "JOB_11", "開始処理", "---");
            win.SetJobInfo("Job12", "JOB_12", "利用状況集計処理", "---");
            win.SetJobInfo("Job13", "JOB_13", "顧客集計処理", "---");
            win.SetJobInfo("Job14", "JOB_14", "売上抽出処理", "---");
            win.Show();
        }

        // ヘッダマウスアップ
        private void lblHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                ShowContextMenu(sender, e);
            }
        }

        // コンテンツマウスアップ
        private void lblContent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //マウス右ボタンクリックなら、コンテキストメニューを表示
                ShowContextMenu(sender, e);
            }
        }

        // フッタマウスアップ
        private void lblFooter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //マウス右ボタンクリックなら、コンテキストメニューを表示
                ShowContextMenu(sender, e);
            }
        }

        // コンテキストメニューを表示する
        //　表示するかどうかの判断は呼出し元で実施済みとする
        private void ShowContextMenu(object sender, MouseEventArgs e)
        {
            //マウス右ボタンクリックなら、コンテキストメニューを表示
            this.JobnetContextMenuStrip.Show();
            // コンテキストメニューの表示位置を設定
            //   コンテキストメニューのLocationはスクリーン座標で設定する
            //   イベント引数eのLocationはイベント発生コントロールのクライアント座標なので
            //   e.Locationをクライアント座標からスクリーン座標に変換して、
            //　 コンテキストメニューの位置を設定する必要がある
            this.JobnetContextMenuStrip.Left = ((Label)sender).PointToScreen(e.Location).X;
            this.JobnetContextMenuStrip.Top = ((Label)sender).PointToScreen(e.Location).Y;
        }

        private void job02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobFlowView2 win = new JobFlowView2();
            win.Text = ((ToolStripMenuItem)sender).Text;
            win.SetJobInfo("Job11", "JOB_21", "開始処理", "---");
            win.SetJobInfo("Job12", "JOB_22", "契約処理", jobListToolStripMenuItem.Tag.ToString());
            win.SetJobInfo("Job13", "JOB_23", "終了処理", "---");
            win.SetJobInfo("Job14", "JOB_24", "連携処理", "---");
            win.Show();
        }

        private void JobListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonListView win = new CommonListView();
            win.Show();
            win.ListTitle = "ジョブ一覧";
            win.Text = "ジョブ一覧";
        }


    }
}
