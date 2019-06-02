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

namespace SysMngToolDemo.HariboteWPF
{
    /// <summary>
    /// MultiLineControl.xaml の相互作用ロジック
    /// </summary>
    public partial class MultiLineControl : UserControl
    {
        int lineWeight = 4;
        int lineMargin = 1;

        public MultiLineControl()
        {
            InitializeComponent();
        }


        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            lineStart.SetValue(Canvas.MarginProperty, new Thickness(lineMargin, lineMargin, this.Width - lineWeight, this.Height / 2 - lineMargin));
            lineHorizont.SetValue(Canvas.MarginProperty, new Thickness(lineMargin, this.Height / 2 - lineWeight / 2, lineMargin, this.Height / 2 - lineWeight / 2));
            lineEnd.SetValue(Canvas.MarginProperty, new Thickness(this.Width - lineMargin - lineWeight, this.Height / 2 - lineWeight / 2, lineMargin, lineMargin));

        }
    }
}
