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

        public void SetTableName(string sTablename)
        {
            lblTableName.Text = sTablename;
        }

        private void tableLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableLayoutView win = new TableLayoutView();
            win.Show();
        }

        private void ShowTableContextMenu(object sender, MouseEventArgs e)
        {
            this.TableContextMenuStrip.Show();
            this.TableContextMenuStrip.Left = this.ParentForm.Location.X + this.Left + e.Location.X;
            this.TableContextMenuStrip.Top = this.ParentForm.Location.Y + this.Top + e.Location.Y;
        }
    }
}
