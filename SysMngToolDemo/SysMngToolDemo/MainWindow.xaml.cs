using SysMngToolDemo.DragMove;
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

namespace SysMngToolDemo
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //public DependencyProperty CompContents
        public List<String> CompContents = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            CompContents.Add("ppp");
            CompContents.Add("hhh");
            this.DataContext = this;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainForm win = new MainForm();
            win.Show();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DragMoveSample win = new DragMoveSample();
            win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Canvas1Ellipse win = new Canvas1Ellipse();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowChromeSamp win = new WindowChromeSamp();
            win.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WinChromeSamp win = new WinChromeSamp();
            //GR.Children.Add(win);
        }
    }
}
