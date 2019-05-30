namespace SysMngToolDemo.Haribote
{
    partial class MultiLineControl
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
            this.LineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.編集仕様ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集仕様ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineHorizont = new System.Windows.Forms.Label();
            this.lineStart = new System.Windows.Forms.Label();
            this.lineEnd = new System.Windows.Forms.Label();
            this.LineContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.編集仕様ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.編集仕様ToolStripMenuItem.Text = "I/F定義";
            // 
            // 編集仕様ToolStripMenuItem1
            // 
            this.編集仕様ToolStripMenuItem1.Name = "編集仕様ToolStripMenuItem1";
            this.編集仕様ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.編集仕様ToolStripMenuItem1.Text = "編集仕様";
            // 
            // lineHorizont
            // 
            this.lineHorizont.BackColor = System.Drawing.Color.Black;
            this.lineHorizont.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lineHorizont.Location = new System.Drawing.Point(4, 70);
            this.lineHorizont.Margin = new System.Windows.Forms.Padding(0);
            this.lineHorizont.Name = "lineHorizont";
            this.lineHorizont.Size = new System.Drawing.Size(144, 5);
            this.lineHorizont.TabIndex = 1;
            this.lineHorizont.Text = "label1";
            this.lineHorizont.MouseLeave += new System.EventHandler(this.lineHorizont_MouseLeave);
            this.lineHorizont.MouseHover += new System.EventHandler(this.lineHorizont_MouseHover);
            this.lineHorizont.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lineHorizont_MouseMove);
            // 
            // lineStart
            // 
            this.lineStart.BackColor = System.Drawing.Color.Black;
            this.lineStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineStart.Location = new System.Drawing.Point(3, 0);
            this.lineStart.Margin = new System.Windows.Forms.Padding(0);
            this.lineStart.Name = "lineStart";
            this.lineStart.Size = new System.Drawing.Size(5, 75);
            this.lineStart.TabIndex = 2;
            this.lineStart.Text = "label1";
            this.lineStart.MouseLeave += new System.EventHandler(this.lineStart_MouseLeave);
            this.lineStart.MouseHover += new System.EventHandler(this.lineStart_MouseHover);
            // 
            // lineEnd
            // 
            this.lineEnd.BackColor = System.Drawing.Color.Black;
            this.lineEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineEnd.Location = new System.Drawing.Point(145, 70);
            this.lineEnd.Margin = new System.Windows.Forms.Padding(0);
            this.lineEnd.Name = "lineEnd";
            this.lineEnd.Size = new System.Drawing.Size(5, 80);
            this.lineEnd.TabIndex = 3;
            this.lineEnd.Text = "label2";
            // 
            // MultiLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lineEnd);
            this.Controls.Add(this.lineStart);
            this.Controls.Add(this.lineHorizont);
            this.Name = "MultiLineControl";
            this.Resize += new System.EventHandler(this.LineControl_Resize);
            this.LineContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip LineContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集仕様ToolStripMenuItem1;
        private System.Windows.Forms.Label lineHorizont;
        private System.Windows.Forms.Label lineStart;
        private System.Windows.Forms.Label lineEnd;
    }
}
