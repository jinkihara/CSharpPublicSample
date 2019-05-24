using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SysMngToolDemo.DragMove
{
    /// <summary>
    /// DragMoveSampl.xaml の相互作用ロジック
    /// </summary>
    public partial class DragMoveSample : Window
    {
        public DragMoveSample()
        {
            InitializeComponent();
        }

        //追加ボタンのイベントハンドラ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DragList.Items.Add(DragList.Items.Count + 1);
        }

        //Thumbコントロールのドラッグイベント処理
        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {

            var thumb = sender as Thumb;
            if (thumb == null) return;

            //親コントロールを探す
            //var parent = thumb.Parent();
            //UIElement parent = (UIElement)thumb.Parent;
            var parent = (UIElement)((Thumb)thumb).Parent;
            if (parent == null) return;
            
            double x = Canvas.GetLeft(parent);
            if (double.IsNaN(x)) x = 0;
            double y = Canvas.GetTop(parent);
            if (double.IsNaN(y)) y = 0;

            //ドラッグ量に応じてThumbコントロールを移動する
            Canvas.SetLeft(parent, x + e.HorizontalChange);
            Canvas.SetTop(parent, y + e.VerticalChange);
        }
    }
}
