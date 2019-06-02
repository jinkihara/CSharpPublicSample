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
            lineStart.Width = lineWeight;
            //lineStart.Height = (this.Height + lineWeight) / 2;

            //lineStart.SetValue(Canvas.LeftProperty, lineMargin);
            //lineStart.SetValue(Canvas.TopProperty, lineMargin);

            //lineHorizont.Height = lineWeight;
            //lineHorizont.Width = this.Width - lineMargin * 2;
            //lineHorizont.SetValue(Canvas.LeftProperty, lineMargin);
            //lineHorizont.SetValue(Canvas.TopProperty, (this.Height - lineWeight) / 2);

            //lineEnd.Width = lineWeight;
            //lineEnd.Height = lineStart.Height;
            //lineEnd.SetValue(Canvas.LeftProperty, lineHorizont.Width - lineWeight + lineMargin);
            //lineEnd.SetValue(Canvas.TopProperty, lineHorizont.GetValue(Canvas.TopProperty));
        }
    }
}
