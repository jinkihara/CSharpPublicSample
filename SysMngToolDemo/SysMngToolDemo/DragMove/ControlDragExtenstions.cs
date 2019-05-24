using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SysMngToolDemo.DragMove
{
    public static class ControlDragExtenstions
    {
        /// <summary>
        /// コントロールのドラッグを有効にする
        /// 親コントロールが Canvas であること
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DragMove(this Control t, object sender, MouseButtonEventArgs e)
        {
            var el = sender as Control;
            var canvas = el.Parent as Canvas;
            var dragOffset = e.GetPosition(el);
            el.CaptureMouse();

            MouseEventHandler mouseMove = null;
            MouseButtonEventHandler mouseUp = null;

            mouseMove = new MouseEventHandler((_, __) =>
            {
                Point pt = Mouse.GetPosition(canvas);
                Canvas.SetLeft(el, pt.X - dragOffset.X);
                Canvas.SetTop(el, pt.Y - dragOffset.Y);
            });
            mouseUp = new MouseButtonEventHandler((_, __) =>
            {
                el.ReleaseMouseCapture();
                el.MouseMove -= mouseMove;
                el.MouseUp -= mouseUp;
            });
            el.MouseMove += mouseMove;
            el.MouseLeftButtonUp += mouseUp;
        }
    }
}
