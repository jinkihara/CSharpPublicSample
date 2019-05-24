using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MongoDBSample
{
    /// <summary>
    /// StdoutSample.xaml の相互作用ロジック
    /// </summary>
    public partial class StdoutSample : Window
    {
        //C# 標準出力を自分のプログラムにリダイレクトする
        // http://cammy.co.jp/technical/2017/05/16/c-%E6%A8%99%E6%BA%96%E5%87%BA%E5%8A%9B%E3%82%92%E8%87%AA%E5%88%86%E3%81%AE%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%A0%E3%81%AB%E3%83%AA%E3%83%80%E3%82%A4%E3%83%AC%E3%82%AF%E3%83%88%E3%81%99/

        //[C#] コンソールアプリの標準入出力を奪ってゴニョゴニョする
        // https://qiita.com/sensuikan1973/items/347eb0b674184bb52384
        public delegate void MyEventHandler(object sender, DataReceivedEventArgs e);
        public event MyEventHandler myEvent = null;

        //WPF 「Shift」単独キーと「Shift＋？」の複合キーを、キーを押された時点で判別できるでしょうか
        // https://social.msdn.microsoft.com/Forums/ja-JP/cdaaa710-b632-4404-a12d-76c5f43e616a/wpf?forum=wpfja


        private Process proc = null;
        private List<string> comHis = new List<string>{""};

        public StdoutSample()
        {
            InitializeComponent();
            commandHistoryComboBox.ItemsSource = comHis;

        }

        private void commandInputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //if (Keyboard.Modifiers == ModifierKeys.Shift)
                //{
                    executeCommands();
                //}
                //else
                //{
                //    commandInputTextBox.Text += '\n';
                //    commandInputTextBox.Select(commandInputTextBox.Text.Length, 0);
                //}

            }
            
        }

        private void executeCommands()
        {
            proc.StandardInput.WriteLine(commandInputTextBox.Text + Environment.NewLine);

            //proc.StartInfo.Arguments = "/c " + commandInputTextBox.Text;
            //proc.Start();
            //commandResultTextBox.Text += proc.StandardOutput.ReadToEnd();
            //commandResultTextBox.Text += proc.StandardError.ReadToEnd();

            //comHis.Add(commandInputTextBox.Text);
            //commandInputTextBox.Text = "";
            //proc.WaitForExit();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            initMongoConsole();

        }

        private void initMongoConsole()
        {
            proc = new Process();

            proc.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.Arguments = "/c dir" ;
            proc.Start();
            
            proc.WaitForExit();

            myEvent = new MyEventHandler(event_DataReceived);
            proc.OutputDataReceived += new DataReceivedEventHandler(process_DataReceived);

        }

        /**
             * @brief 非同期で出力を読み込む
             *        メインスレッドにアクセスする場合は、Invokeメソッドを利用し、スレッドの同期をとる必要がある
             */
        void process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //this.Invoke(myEvent, new object[2] { sender, e });
        }

        /**
         * @brief XXX.exeの標準出力を見て、その内容に応じて処理をしてみる     
         */
        void event_DataReceived(object sender, DataReceivedEventArgs e)
        {
            // --------------------
            // e.Dataの中身を見て、色々処理できる！
            // --------------------

            // 例えば、"星"という文字が出力に含まれていたら、"Starだね"という文字を標準入力してみる
            if (e.Data.Contains("星"))
            {
                proc.StandardInput.WriteLine("Starだね");
            }
        }



    }
}
