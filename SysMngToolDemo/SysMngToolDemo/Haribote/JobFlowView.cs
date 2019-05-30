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
    public partial class JobFlowView : Form
    {
        public JobFlowView()
        {
            InitializeComponent();
        }

        public void SetJobInfo(string jobId, string jobHeader, string jobContent, string jobFooter)
        {
            ((JobControl)this.Controls[jobId]).Controls["lblHeader"].Text = jobHeader;
            ((JobControl)this.Controls[jobId]).Controls["lblContent"].Text = jobContent;
            ((JobControl)this.Controls[jobId]).Controls["lblFooter"].Text = jobFooter;
        }

        private void lblToDB_MouseHover(object sender, EventArgs e)
        {
            
        }

        LineControl2 l2 = new LineControl2();
        Label lbl = new Label();
        private void lineControl1_MouseHover(object sender, EventArgs e)
        {
            l2 = new LineControl2();
            l2.Name = "CommentLine";
            l2.Size = new Size(30, 80);
            l2.Location = new Point(((LineControl)sender).PointToScreen(((MouseEventArgs)e).Location).X, ((LineControl)sender).PointToScreen(((MouseEventArgs)e).Location).Y-l2.Height);
            this.Controls.Add(l2);

            lbl = new Label();
            lbl.Name = "CommentLabel";
            lbl.Size = new Size(250,80);
            lbl.Location = new Point(l2.Left+l2.Width,l2.Top-lbl.Height);
            lbl.Text = "登録情報　：売上情報" + Environment.NewLine + "集計キー　：契約番号";
            this.Controls.Add(lbl);
        }

        private void lineControl1_MouseLeave(object sender, EventArgs e)
        {
            this.Controls[l2.Name].Dispose();
            this.Controls[lbl.Name].Dispose();
        }

    }
}
