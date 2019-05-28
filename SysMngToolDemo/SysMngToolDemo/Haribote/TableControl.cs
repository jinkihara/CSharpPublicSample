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
            win.ListTitle = "定例１次入力(REGULAR_CREDIT_1_INPUT)";

            DataTable dt = new DataTable("Dummy");
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("DataType", typeof(string));
            dt.Columns.Add("TotalSize", typeof(int));

            dt.Rows.Add(new object[] {"与信処理種別", "CHAR", 2 });
            dt.Rows.Add(new object[] { "申込番号", "CHAR", 16}); 
            dt.Rows.Add(new object[] { "契約番号", "CHAR", 16});
            dt.Rows.Add(new object[] { "顧客番号", "CHAR", 11});
            dt.Rows.Add(new object[] { "セグメント", "CHAR", 4 });

            win.dgrList.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "ItemName";
            col.HeaderText = "項目";
            win.dgrList.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "DataType";
            col.HeaderText = "型";
            win.dgrList.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "TotalSize";
            col.HeaderText = "総桁";
            win.dgrList.Columns.Add(col);
            win.dgrList.AllowUserToAddRows = false;

            win.dgrList.Rows.Clear();

            win.dgrList.DataSource = dt;

        }

        private void ShowTableContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.TableContextMenuStrip.Show();
                this.TableContextMenuStrip.Left = this.ParentForm.Location.X + this.Left + e.Location.X;
                this.TableContextMenuStrip.Top = this.ParentForm.Location.Y + this.Top + e.Location.Y;
            }
        }
    }

    public class TableLayout
    {
        public string ItemName { get; set; }
        public string DataType { get; set; }
        public int TotalSize { get; set; }

    }
}
