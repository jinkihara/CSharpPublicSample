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
        bool isResizing = false;

        double preX = -1;
        double preY = -1;
        double dX = 0;
        double dY = 0;


        int lineWeight = 4;
        int lineMargin = 5;
        int resizeMargin = 10;

        public MultiLineControl()
        {
            InitializeComponent();
        }


        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            lineStart.SetValue(Canvas.MarginProperty, new Thickness(lineMargin, lineMargin, this.Width - lineWeight-lineMargin, this.Height / 2 - lineWeight/2));
            lineHorizont.SetValue(Canvas.MarginProperty, new Thickness(lineMargin, this.Height / 2 - lineWeight / 2, lineMargin, this.Height / 2 - lineWeight / 2));
            lineEnd.SetValue(Canvas.MarginProperty, new Thickness(this.Width - lineMargin - lineWeight, this.Height / 2 - lineWeight / 2, lineMargin, lineMargin));

        }


        private void multiLineControl_MouseMove(object sender, MouseEventArgs e)
        {
            double X = e.GetPosition(this).X;
            double Y = e.GetPosition(this).Y;
            dX = X-preX;
            dY = Y-preY;

            if (e.LeftButton == MouseButtonState.Released)
            {
                if (X < resizeMargin)
                {
                    if (Y < resizeMargin)
                    {
                        // 左上
                        this.Cursor = Cursors.ScrollNW;
                    }
                    else if (Y > this.Height - resizeMargin)
                    {
                        // 左下
                        this.Cursor = Cursors.ScrollSW;
                    }
                    else
                    {
                        // 左
                        this.Cursor = Cursors.ScrollWE;
                    }
                }
                else if (X > this.Width - resizeMargin)
                {
                    if (Y < resizeMargin)
                    {
                        // 右上
                        this.Cursor = Cursors.ScrollNE;
                    }
                    else if (Y > this.Height - resizeMargin)
                    {
                        // 右下
                        this.Cursor = Cursors.ScrollSE;
                    }
                    else
                    {
                        // 右
                        this.Cursor = Cursors.ScrollWE;
                    }

                }
                else
                {
                    if (Y < resizeMargin)
                    {
                        // 上
                        this.Cursor = Cursors.ScrollNS;
                    }
                    else if (Y > this.Height - resizeMargin)
                    {
                        // 下
                        this.Cursor = Cursors.ScrollNS;
                    }
                    else
                    {
                        this.Cursor = Cursors.Arrow;
                    }

                }
            }
            else
            {
                if (dX > 2 || dY > 2)
                {
                    if (this.Cursor == Cursors.Hand)
                    {

                    }
                    else if (this.Cursor == Cursors.ScrollWE)
                    {
                        Canvas.SetLeft(this, (double)this.GetValue(Canvas.LeftProperty) + dX);
                        this.Width = Math.Abs(this.Width - dX);
                    }
                }
            }
            preX = X;
            preY = Y;
        }

        private void multiLineControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && this.Cursor == Cursors.Arrow)
            {
                this.Cursor = Cursors.Hand;
            }
            this.CaptureMouse();
            dX = 0;
            dY = 0;
            preX = this.PointToScreen(e.GetPosition(this)).X; //e.GetPosition(this).X;
            preY = this.PointToScreen(e.GetPosition(this)).Y; //e.GetPosition(this).Y;
        }

        private void multiLineControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            this.ReleaseMouseCapture();
            preX = this.PointToScreen(e.GetPosition(this)).X; //e.GetPosition(this).X;
            preY = this.PointToScreen(e.GetPosition(this)).Y; //e.GetPosition(this).Y;
        }
    }
}
