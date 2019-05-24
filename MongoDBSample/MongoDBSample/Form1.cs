using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBSample
{
    public partial class Form1 : Form
    {
        //// 同ディレクトリにあるXXX.exeのパスを取得
        //string XXX_Path = Path.GetDirectoryName(Application.ExecutablePath) + "XXX.exe";

        // イベントハンドラ
        public delegate void MyEventHandler(object sender, DataReceivedEventArgs e);
        public event MyEventHandler myEvent = null;

        // 外部プロセス(XXX.exe)を宣言
        Process xxx_process = null;

        public Form1()
        {
            InitializeComponent();

            //イベントハンドラを作成
            myEvent = new MyEventHandler(event_DataReceived);

            xxx_process = new Process();
            // パス指定
            //xxx_process.StartInfo.FileName = XXX_Path;
            xxx_process.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            xxx_process.StartInfo.Arguments = "/K C:\\MongoDB\\bin\\mongo.exe";

            // 非同期処理のために、ShellExecuteを使わない設定にする
            // BeginOutputReadLine()を利用するための条件
            xxx_process.StartInfo.UseShellExecute = false;

            // 非同期読込での完了イベントとなるイベントハンドラを設定
            // BeginOutputReadLine()を利用するための条件
            xxx_process.OutputDataReceived += new DataReceivedEventHandler(process_DataReceived);

            // 標準入出力をリダイレクト
            xxx_process.StartInfo.RedirectStandardOutput = true;
            xxx_process.StartInfo.RedirectStandardError = true;
            xxx_process.StartInfo.RedirectStandardInput = true;

            // XXX.exeのコンソールは邪魔なので開かない
            xxx_process.StartInfo.CreateNoWindow = true;

            // ついにプロセス起動！
            xxx_process.Start();

            // 標準出力の非同期読込を開始
            xxx_process.BeginOutputReadLine();
        }

        /**
         * @brief 非同期で出力を読み込む
         *        メインスレッドにアクセスする場合は、Invokeメソッドを利用し、スレッドの同期をとる必要がある
         */
        void process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!xxx_process.HasExited)
                this.Invoke(myEvent, new object[2] { sender, e });
        }

        /**
         * @brief XXX.exeの標準出力を見て、その内容に応じて処理をしてみる     
         */
        void event_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // --------------------
                // e.Dataの中身を見て、色々処理できる！
                // --------------------
                textBox2.Text += e.Data+Environment.NewLine;
                textBox2.Select(textBox2.Text.Length, 0);
                textBox2.ScrollToCaret();
                if (xxx_process.HasExited)
                {
                    this.Close();
                }
            }
        }

        /**
         * @brief Formロード時
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Formが閉じられた時のイベントを登録
            this.FormClosed += new FormClosedEventHandler(Form1_Closed);
        }

        /**
         * @brief Formが閉じられた時の処理
         *        外部プロセス(xxx.exe)をkillする
         */
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            try
            {
                if (xxx_process != null)
                {
                    xxx_process.Kill();
                    xxx_process.Close();
                    xxx_process.Dispose();
                }
            }
            catch (InvalidOperationException exc) { }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (xxx_process.HasExited)
                {
                    this.Close();
                }
                else
                {
                    xxx_process.StandardInput.WriteLine(textBox1.Text + Environment.NewLine);
                    textBox2.Text += "> " + textBox1.Text + Environment.NewLine;
                }
            }
        }

    }
}
