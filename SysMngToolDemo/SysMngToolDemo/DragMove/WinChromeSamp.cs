using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shell;

namespace SysMngToolDemo.DragMove
{
    class WinChromeSamp : WindowChrome
    {
        public WinChromeSamp()
        {
            this.ResizeBorderThickness = new System.Windows.Thickness(5);
            
        }
    }
}
