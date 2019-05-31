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

namespace SysMngToolDemo.Components
{
    /// <summary>
    /// BaseComponent.xaml の相互作用ロジック
    /// </summary>
    public partial class BaseComponent : UserControl
    {
        private bool isDragging = false;

        public string HeaderTitle { get; set; }
        public static readonly DependencyProperty ComponentContentsProperty =
            DependencyProperty.Register(
                "ComponentContents",
                typeof(List<string>),
                typeof(BaseComponent),
                new PropertyMetadata(
                    new List<string>()));
        public List<string> ComponentContents
        {
            get { return (List<string>)GetValue(ComponentContentsProperty); }
            set { SetValue(ComponentContentsProperty, value); }
        }
        public string Footer { get; set; }

        public BaseComponent()
        {
            InitializeComponent();
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.Cross;
            isDragging = true;
            
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.Arrow;
            isDragging = false;
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            if (isDragging)
            {
                
            }
        }

        // 
        private void ComponentName_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.Cross;
            isDragging = true;
        }

        private void ComponentName_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.Arrow;
            isDragging = false;
        }

        private void ComponentName_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                
            }
        }
    }
}
