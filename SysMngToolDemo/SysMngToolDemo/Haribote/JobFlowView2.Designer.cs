namespace SysMngToolDemo.Haribote
{
    partial class JobFlowView2
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
            this.line01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JobContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moduleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Job14 = new SysMngToolDemo.Haribote.JobControl();
            this.Job13 = new SysMngToolDemo.Haribote.JobControl();
            this.Job12 = new SysMngToolDemo.Haribote.JobControl();
            this.Job11 = new SysMngToolDemo.Haribote.JobControl();
            this.JobContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // line01
            // 
            this.line01.BackColor = System.Drawing.Color.Black;
            this.line01.Location = new System.Drawing.Point(118, 275);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(178, 3);
            this.line01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 30);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 40);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 20);
            this.label3.TabIndex = 4;
            // 
            // LineContextMenuStrip
            // 
            this.LineContextMenuStrip.Name = "LineContextMenuStrip";
            this.LineContextMenuStrip.Size = new System.Drawing.Size(61, 4);
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
            // Job14
            // 
            this.Job14.Location = new System.Drawing.Point(239, 290);
            this.Job14.Name = "Job14";
            this.Job14.Size = new System.Drawing.Size(117, 107);
            this.Job14.TabIndex = 7;
            // 
            // Job13
            // 
            this.Job13.Location = new System.Drawing.Point(60, 290);
            this.Job13.Name = "Job13";
            this.Job13.Size = new System.Drawing.Size(117, 107);
            this.Job13.TabIndex = 6;
            // 
            // Job12
            // 
            this.Job12.Location = new System.Drawing.Point(60, 150);
            this.Job12.Name = "Job12";
            this.Job12.Size = new System.Drawing.Size(117, 107);
            this.Job12.TabIndex = 5;
            // 
            // Job11
            // 
            this.Job11.Location = new System.Drawing.Point(60, 12);
            this.Job11.Name = "Job11";
            this.Job11.Size = new System.Drawing.Size(117, 107);
            this.Job11.TabIndex = 0;
            // 
            // JobFlowView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 443);
            this.Controls.Add(this.Job14);
            this.Controls.Add(this.Job13);
            this.Controls.Add(this.Job12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line01);
            this.Controls.Add(this.Job11);
            this.Name = "JobFlowView2";
            this.Text = "JobFlowView";
            this.JobContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JobControl Job11;
        private System.Windows.Forms.Label line01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
    }
}