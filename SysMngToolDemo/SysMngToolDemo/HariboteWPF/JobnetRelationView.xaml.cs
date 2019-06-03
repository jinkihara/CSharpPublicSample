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
using System.Windows.Shapes;

namespace SysMngToolDemo.HariboteWPF
{
    /// <summary>
    /// JobnetRelationView.xaml の相互作用ロジック
    /// </summary>
    public partial class JobnetRelationView : Window
    {
        public JobnetRelationView()
        {
            InitializeComponent();
            jobnet01.MouseLeftButtonDown += (sender, e) =>
            {
                jobnet01.DragMove(sender, e);
            };
            line01.MouseLeftButtonDown += (sender, e) =>
            {
                line01.DragMove(sender, e);
            };
        }

        public void DoDragging(object sender ,Point moveDistance, Size resizeVolume)
        {
            
        }
    }
}
