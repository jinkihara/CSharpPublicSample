namespace SysMngToolDemo.Haribote
{
    partial class JobnetControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.JobnetContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jobListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobFlowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.job01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.job02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JobnetContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(150, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseUp);
            // 
            // lblFooter
            // 
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 127);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(150, 23);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = "label2";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContent
            // 
            this.lblContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Location = new System.Drawing.Point(0, 23);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(150, 104);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "label3";
            // 
            // JobnetContextMenuStrip
            // 
            this.JobnetContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobListToolStripMenuItem,
            this.jobFlowsToolStripMenuItem});
            this.JobnetContextMenuStrip.Name = "JobnetContextMenuStrip";
            this.JobnetContextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // jobListToolStripMenuItem
            // 
            this.jobListToolStripMenuItem.Name = "jobListToolStripMenuItem";
            this.jobListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jobListToolStripMenuItem.Text = "Job List";
            this.jobListToolStripMenuItem.Click += new System.EventHandler(this.JobListToolStripMenuItem_Click);
            // 
            // jobFlowsToolStripMenuItem
            // 
            this.jobFlowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.job01ToolStripMenuItem,
            this.job02ToolStripMenuItem});
            this.jobFlowsToolStripMenuItem.Name = "jobFlowsToolStripMenuItem";
            this.jobFlowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jobFlowsToolStripMenuItem.Text = "Job Flows";
            // 
            // job01ToolStripMenuItem
            // 
            this.job01ToolStripMenuItem.Name = "job01ToolStripMenuItem";
            this.job01ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.job01ToolStripMenuItem.Text = "Job01";
            this.job01ToolStripMenuItem.Click += new System.EventHandler(this.job01ToolStripMenuItem_Click);
            // 
            // job02ToolStripMenuItem
            // 
            this.job02ToolStripMenuItem.Name = "job02ToolStripMenuItem";
            this.job02ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.job02ToolStripMenuItem.Text = "Job02";
            this.job02ToolStripMenuItem.Click += new System.EventHandler(this.job02ToolStripMenuItem_Click);
            // 
            // JobnetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Name = "JobnetControl";
            this.JobnetContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ContextMenuStrip JobnetContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem jobListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobFlowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem job01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem job02ToolStripMenuItem;
    }
}
