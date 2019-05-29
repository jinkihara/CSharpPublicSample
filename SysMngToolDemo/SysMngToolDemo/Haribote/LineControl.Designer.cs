namespace SysMngToolDemo.Haribote
{
    partial class LineControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.LineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.編集仕様ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集仕様ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LineContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // LineContextMenuStrip
            // 
            this.LineContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集仕様ToolStripMenuItem,
            this.編集仕様ToolStripMenuItem1});
            this.LineContextMenuStrip.Name = "LineContextMenuStrip";
            this.LineContextMenuStrip.Size = new System.Drawing.Size(125, 48);
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
            // LineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Name = "LineControl";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LineControl_MouseUp);
            this.Resize += new System.EventHandler(this.LineControl_Resize);
            this.LineContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip LineContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem1;
    }
}
