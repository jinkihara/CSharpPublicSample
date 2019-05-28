namespace SysMngToolDemo.Haribote
{
    partial class JobnetView
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
            this.jobnetControl1 = new SysMngToolDemo.Haribote.JobnetControl();
            this.JobnetContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowJoblistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JobsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowJob01MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowJob02MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JobnetContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobnetControl1
            // 
            this.jobnetControl1.ContentText = "契約登録";
            this.jobnetControl1.FooterText = "---";
            this.jobnetControl1.HeaderText = "JOBNET001";
            this.jobnetControl1.Location = new System.Drawing.Point(92, 48);
            this.jobnetControl1.Name = "jobnetControl1";
            this.jobnetControl1.Size = new System.Drawing.Size(98, 100);
            this.jobnetControl1.TabIndex = 0;
            // 
            // JobnetContextMenu
            // 
            this.JobnetContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowJoblistMenuItem,
            this.JobsMenuItem});
            this.JobnetContextMenu.Name = "JobnetContextMenu";
            this.JobnetContextMenu.Size = new System.Drawing.Size(114, 48);
            // 
            // ShowJoblistMenuItem
            // 
            this.ShowJoblistMenuItem.Name = "ShowJoblistMenuItem";
            this.ShowJoblistMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ShowJoblistMenuItem.Text = "Job List";
            // 
            // JobsMenuItem
            // 
            this.JobsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowJob01MenuItem,
            this.ShowJob02MenuItem});
            this.JobsMenuItem.Name = "JobsMenuItem";
            this.JobsMenuItem.Size = new System.Drawing.Size(113, 22);
            this.JobsMenuItem.Text = "Jobs";
            // 
            // ShowJob01MenuItem
            // 
            this.ShowJob01MenuItem.Name = "ShowJob01MenuItem";
            this.ShowJob01MenuItem.Size = new System.Drawing.Size(104, 22);
            this.ShowJob01MenuItem.Text = "Job01";
            // 
            // ShowJob02MenuItem
            // 
            this.ShowJob02MenuItem.Name = "ShowJob02MenuItem";
            this.ShowJob02MenuItem.Size = new System.Drawing.Size(104, 22);
            this.ShowJob02MenuItem.Text = "Job02";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // JobnetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 422);
            this.Controls.Add(this.jobnetControl1);
            this.Name = "JobnetView";
            this.Text = "JobnetView";
            this.JobnetContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JobnetControl jobnetControl1;
        private System.Windows.Forms.ContextMenuStrip JobnetContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowJoblistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JobsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowJob01MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowJob02MenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}