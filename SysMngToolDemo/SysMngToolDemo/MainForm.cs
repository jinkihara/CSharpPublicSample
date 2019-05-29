using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMngToolDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lblScreen.Text = Cursor.Position.ToString();
            lblClientForm.Text = this.PointToClient(Cursor.Position).ToString();
            lblClientControl.Text = label2.PointToClient(Cursor.Position).ToString();
            lblEventArgs.Text = e.Location.ToString();
            lblEventToScreen.Text=label2.PointToScreen(e.Location).ToString();
        }
    }
}
