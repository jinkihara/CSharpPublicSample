using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo.Haribote
{
    public partial class CommonListView : Form
    {
        public CommonListView()
        {
            InitializeComponent();
        }
        public string ListTitle
        {
            get { return lblListName.Text; }
            set { lblListName.Text = value; }
        }
    }
}
