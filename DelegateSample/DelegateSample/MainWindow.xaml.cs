using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegateSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //C# デリゲートについて
        // https://qiita.com/ysn551/items/71fe3f332ea9a3114d36

        public MainWindow()
        {
            InitializeComponent();
        }

        #region 引数１つのパターン

        // デリゲートの宣言
        delegate void Printer(string s);

        #region newキーワードによる生成
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // newキーワードによる生成
            Printer print1 = new Printer(Console.WriteLine);

            print1("Hey!");
        }
        #endregion newキーワードによる生成

        #region 匿名メソッドによる生成
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Printer print2 = delegate(string s)
            {
                Console.WriteLine(s);
            };

            print2("Hey!Hey!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Printer print3 = delegate (string s) {
                Console.WriteLine("ここ⇒\"{0}\"に埋め込むことも可能", s);
            };

            print3("Hey!Hey!Hey!!");
        }
        #endregion 匿名メソッドによる生成

        #region ラムダ式による生成
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Printer print4 = (string s) =>
            {
                Console.WriteLine("ここ⇒\"{0}\"に埋め込むことも可能", s);
            };

            print4("Hey!Hey!Hey!Hey!!");
        }
        #endregion ラムダ式による生成

        #endregion 引数１つのパターン

        #region 引数２つのパターン

        // デリゲートの宣言
        delegate void Printer2(string s1, int s2);  // ここで引数を２つ指定する

        #region newなしで代入
        // https://ufcpp.net/study/csharp/sp_delegate.html
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Printer2 print0 = WriteLine;
            print0("代入の１", 9);
        }
        #endregion newなしで代入

        #region newキーワードによる生成
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Printer2 print5 = new Printer2(WriteLine);

            print5("１番目", 2);
        }
        #endregion newキーワードによる生成

        #region ラムダ式による生成
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Printer2 print6 = (string s1, int s2) =>
            {
                WriteLine(s1, s2);
            };

            print6("第１", 2);
        }
        #endregion ラムダ式による生成

        private void WriteLine(string s1, int s2)
        {
            Console.WriteLine("第１引数：{0}／第２引数：{1}", s1, s2);
        }

        #endregion 引数２つのパターン


    }
}
