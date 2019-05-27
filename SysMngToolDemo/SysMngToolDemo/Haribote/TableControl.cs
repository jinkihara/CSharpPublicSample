using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo.Haribote
{
    public partial class TableControl : UserControl
    {
        public TableControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public string TableName
        {
            get { return lblTableName.Text; }
            set { lblTableName.Text = value; }
        }

        private void tableLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonListView win = new CommonListView();
            win.Show();
            win.Text = "Table Layout Definition";
            win.ListTitle = "契約管理(ContactManage)";
            
        }

        private void ShowTableContextMenu(object sender, MouseEventArgs e)
        {
            this.TableContextMenuStrip.Show();
            this.TableContextMenuStrip.Left = this.ParentForm.Location.X + this.Left + e.Location.X;
            this.TableContextMenuStrip.Top = this.ParentForm.Location.Y + this.Top + e.Location.Y;
        }
    }
}
