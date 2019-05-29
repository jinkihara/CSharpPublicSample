namespace SysMngToolDemo.Haribote
{
    partial class JobFlowView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobFlowView));
            this.LineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JobContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moduleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRegistDetail = new System.Windows.Forms.TextBox();
            this.lineTextDetail = new SysMngToolDemo.Haribote.LineControl2();
            this.lineControl1 = new SysMngToolDemo.Haribote.LineControl();
            this.tableControl1 = new SysMngToolDemo.Haribote.TableControl();
            this.Job14 = new SysMngToolDemo.Haribote.JobControl();
            this.Job13 = new SysMngToolDemo.Haribote.JobControl();
            this.Job12 = new SysMngToolDemo.Haribote.JobControl();
            this.Job11 = new SysMngToolDemo.Haribote.JobControl();
            this.lineControl2 = new SysMngToolDemo.Haribote.LineControl();
            this.lineControl3 = new SysMngToolDemo.Haribote.LineControl();
            this.lineControl4 = new SysMngToolDemo.Haribote.LineControl();
            this.lineControl5 = new SysMngToolDemo.Haribote.LineControl();
            this.編集仕様ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集仕様ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LineContextMenuStrip.SuspendLayout();
            this.JobContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineContextMenuStrip
            // 
            this.LineContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集仕様ToolStripMenuItem,
            this.編集仕様ToolStripMenuItem1});
            this.LineContextMenuStrip.Name = "LineContextMenuStrip";
            this.LineContextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // JobContextMenuStrip
            // 
            this.JobContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleListToolStripMenuItem,
            this.tableListToolStripMenuItem,
            this.fileListToolStripMenuItem,
            this.formListToolStripMenuItem,
            this.windowListToolStripMenuItem});
            this.JobContextMenuStrip.Name = "JobContextMenuStrip";
            this.JobContextMenuStrip.Size = new System.Drawing.Size(143, 114);
            // 
            // moduleListToolStripMenuItem
            // 
            this.moduleListToolStripMenuItem.Name = "moduleListToolStripMenuItem";
            this.moduleListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.moduleListToolStripMenuItem.Text = "Module List";
            // 
            // tableListToolStripMenuItem
            // 
            this.tableListToolStripMenuItem.Name = "tableListToolStripMenuItem";
            this.tableListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tableListToolStripMenuItem.Text = "Table List";
            // 
            // fileListToolStripMenuItem
            // 
            this.fileListToolStripMenuItem.Name = "fileListToolStripMenuItem";
            this.fileListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fileListToolStripMenuItem.Text = "File List";
            // 
            // formListToolStripMenuItem
            // 
            this.formListToolStripMenuItem.Name = "formListToolStripMenuItem";
            this.formListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.formListToolStripMenuItem.Text = "Form List";
            // 
            // windowListToolStripMenuItem
            // 
            this.windowListToolStripMenuItem.Name = "windowListToolStripMenuItem";
            this.windowListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.windowListToolStripMenuItem.Text = "Screen List";
            // 
            // txtRegistDetail
            // 
            this.txtRegistDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistDetail.Location = new System.Drawing.Point(491, 215);
            this.txtRegistDetail.Multiline = true;
            this.txtRegistDetail.Name = "txtRegistDetail";
            this.txtRegistDetail.Size = new System.Drawing.Size(140, 35);
            this.txtRegistDetail.TabIndex = 14;
            this.txtRegistDetail.Text = "登録データ：売上情報\r\n集計キー　：契約番号";
            this.txtRegistDetail.Visible = false;
            // 
            // lineTextDetail
            // 
            this.lineTextDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineTextDetail.BackgroundImage")));
            this.lineTextDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineTextDetail.Location = new System.Drawing.Point(473, 249);
            this.lineTextDetail.Name = "lineTextDetail";
            this.lineTextDetail.Size = new System.Drawing.Size(22, 57);
            this.lineTextDetail.TabIndex = 15;
            this.lineTextDetail.Visible = false;
            // 
            // lineControl1
            // 
            this.lineControl1.BackColor = System.Drawing.Color.Transparent;
            this.lineControl1.Location = new System.Drawing.Point(448, 305);
            this.lineControl1.Margin = new System.Windows.Forms.Padding(5);
            this.lineControl1.Name = "lineControl1";
            this.lineControl1.Size = new System.Drawing.Size(77, 10);
            this.lineControl1.TabIndex = 13;
            this.lineControl1.MouseLeave += new System.EventHandler(this.lineControl1_MouseLeave);
            this.lineControl1.MouseHover += new System.EventHandler(this.lineControl1_MouseHover);
            // 
            // tableControl1
            // 
            this.tableControl1.Location = new System.Drawing.Point(525, 261);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(106, 95);
            this.tableControl1.TabIndex = 12;
            this.tableControl1.TableName = "売上管理SalesManage";
            // 
            // Job14
            // 
            this.Job14.ContentString = "売上抽出";
            this.Job14.FooterString = "---";
            this.Job14.HeaderString = "JOB01003";
            this.Job14.Location = new System.Drawing.Point(331, 250);
            this.Job14.Name = "Job14";
            this.Job14.Size = new System.Drawing.Size(117, 107);
            this.Job14.TabIndex = 7;
            // 
            // Job13
            // 
            this.Job13.ContentString = "〇〇〇";
            this.Job13.FooterString = "---";
            this.Job13.HeaderString = "JOB01002";
            this.Job13.Location = new System.Drawing.Point(194, 250);
            this.Job13.Name = "Job13";
            this.Job13.Size = new System.Drawing.Size(117, 107);
            this.Job13.TabIndex = 6;
            // 
            // Job12
            // 
            this.Job12.ContentString = "〇〇〇";
            this.Job12.FooterString = "---";
            this.Job12.HeaderString = "JOB01001";
            this.Job12.Location = new System.Drawing.Point(50, 249);
            this.Job12.Name = "Job12";
            this.Job12.Size = new System.Drawing.Size(117, 107);
            this.Job12.TabIndex = 5;
            // 
            // Job11
            // 
            this.Job11.ContentString = "〇〇〇";
            this.Job11.FooterString = "---";
            this.Job11.HeaderString = "JOB01000";
            this.Job11.Location = new System.Drawing.Point(52, 42);
            this.Job11.Name = "Job11";
            this.Job11.Size = new System.Drawing.Size(117, 107);
            this.Job11.TabIndex = 0;
            // 
            // lineControl2
            // 
            this.lineControl2.BackColor = System.Drawing.Color.Transparent;
            this.lineControl2.Location = new System.Drawing.Point(102, 150);
            this.lineControl2.Name = "lineControl2";
            this.lineControl2.Size = new System.Drawing.Size(10, 99);
            this.lineControl2.TabIndex = 16;
            // 
            // lineControl3
            // 
            this.lineControl3.BackColor = System.Drawing.Color.Transparent;
            this.lineControl3.Location = new System.Drawing.Point(248, 203);
            this.lineControl3.Name = "lineControl3";
            this.lineControl3.Size = new System.Drawing.Size(10, 47);
            this.lineControl3.TabIndex = 17;
            // 
            // lineControl4
            // 
            this.lineControl4.BackColor = System.Drawing.Color.Transparent;
            this.lineControl4.Location = new System.Drawing.Point(386, 203);
            this.lineControl4.Name = "lineControl4";
            this.lineControl4.Size = new System.Drawing.Size(10, 47);
            this.lineControl4.TabIndex = 18;
            // 
            // lineControl5
            // 
            this.lineControl5.BackColor = System.Drawing.Color.Transparent;
            this.lineControl5.Location = new System.Drawing.Point(110, 201);
            this.lineControl5.Name = "lineControl5";
            this.lineControl5.Size = new System.Drawing.Size(278, 10);
            this.lineControl5.TabIndex = 19;
            // 
            // 編集仕様ToolStripMenuItem
            // 
            this.編集仕様ToolStripMenuItem.Name = "編集仕様ToolStripMenuItem";
            this.編集仕様ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.編集仕様ToolStripMenuItem.Text = "I/F定義";
            // 
            // 編集仕様ToolStripMenuItem1
            // 
            this.編集仕様ToolStripMenuItem1.Name = "編集仕様ToolStripMenuItem1";
            this.編集仕様ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.編集仕様ToolStripMenuItem1.Text = "編集仕様";
            // 
            // JobFlowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 380);
            this.Controls.Add(this.lineControl5);
            this.Controls.Add(this.lineControl4);
            this.Controls.Add(this.lineControl3);
            this.Controls.Add(this.lineControl2);
            this.Controls.Add(this.lineTextDetail);
            this.Controls.Add(this.txtRegistDetail);
            this.Controls.Add(this.lineControl1);
            this.Controls.Add(this.tableControl1);
            this.Controls.Add(this.Job14);
            this.Controls.Add(this.Job13);
            this.Controls.Add(this.Job12);
            this.Controls.Add(this.Job11);
            this.Name = "JobFlowView";
            this.Text = "JobFlowView";
            this.LineContextMenuStrip.ResumeLayout(false);
            this.JobContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobControl Job11;
        private JobControl Job12;
        private JobControl Job13;
        private JobControl Job14;
        private System.Windows.Forms.ContextMenuStrip LineContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip JobContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem moduleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowListToolStripMenuItem;
        private TableControl tableControl1;
        private LineControl lineControl1;
        private System.Windows.Forms.TextBox txtRegistDetail;
        private LineControl2 lineTextDetail;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem1;
        private LineControl lineControl2;
        private LineControl lineControl3;
        private LineControl lineControl4;
        private LineControl lineControl5;
    }
}