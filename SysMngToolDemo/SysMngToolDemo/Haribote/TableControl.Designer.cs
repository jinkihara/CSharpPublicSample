namespace SysMngToolDemo.Haribote
{
    partial class TableControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableControl));
            this.imgDatabase = new System.Windows.Forms.PictureBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.TableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgDatabase)).BeginInit();
            this.TableContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDatabase
            // 
            this.imgDatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgDatabase.BackgroundImage")));
            this.imgDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgDatabase.Image = ((System.Drawing.Image)(resources.GetObject("imgDatabase.Image")));
            this.imgDatabase.InitialImage = null;
            this.imgDatabase.Location = new System.Drawing.Point(0, 0);
            this.imgDatabase.Name = "imgDatabase";
            this.imgDatabase.Size = new System.Drawing.Size(150, 150);
            this.imgDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDatabase.TabIndex = 0;
            this.imgDatabase.TabStop = false;
            this.imgDatabase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowTableContextMenu);
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableName.BackColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(3, 58);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(144, 29);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "label1";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTableName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowTableContextMenu);
            // 
            // TableContextMenuStrip
            // 
            this.TableContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseInfoToolStripMenuItem,
            this.tableLayoutToolStripMenuItem});
            this.TableContextMenuStrip.Name = "TableContextMenuStrip";
            this.TableContextMenuStrip.Size = new System.Drawing.Size(159, 48);
            // 
            // tableLayoutToolStripMenuItem
            // 
            this.tableLayoutToolStripMenuItem.Name = "tableLayoutToolStripMenuItem";
            this.tableLayoutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tableLayoutToolStripMenuItem.Text = "Table Layout";
            this.tableLayoutToolStripMenuItem.Click += new System.EventHandler(this.tableLayoutToolStripMenuItem_Click);
            // 
            // databaseInfoToolStripMenuItem
            // 
            this.databaseInfoToolStripMenuItem.Name = "databaseInfoToolStripMenuItem";
            this.databaseInfoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.databaseInfoToolStripMenuItem.Text = "Database Info";
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.imgDatabase);
            this.Name = "TableControl";
            ((System.ComponentModel.ISupportInitialize)(this.imgDatabase)).EndInit();
            this.TableContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDatabase;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.ContextMenuStrip TableContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableLayoutToolStripMenuItem;
    }
}
