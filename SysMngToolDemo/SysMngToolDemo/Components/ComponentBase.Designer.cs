namespace SysMngToolDemo.Components
{
    partial class ComponentBase
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
            this.ControlEdgeTable = new System.Windows.Forms.TableLayoutPanel();
            this.ControlContinerPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ContentsContainerPanel = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ControlEdgeTable.SuspendLayout();
            this.ControlContinerPanel.SuspendLayout();
            this.ContentsContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlEdgeTable
            // 
            this.ControlEdgeTable.ColumnCount = 3;
            this.ControlEdgeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.298013F));
            this.ControlEdgeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.70199F));
            this.ControlEdgeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.ControlEdgeTable.Controls.Add(this.ControlContinerPanel, 1, 1);
            this.ControlEdgeTable.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ControlEdgeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlEdgeTable.Location = new System.Drawing.Point(0, 0);
            this.ControlEdgeTable.Name = "ControlEdgeTable";
            this.ControlEdgeTable.RowCount = 3;
            this.ControlEdgeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.696203F));
            this.ControlEdgeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.30379F));
            this.ControlEdgeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.ControlEdgeTable.Size = new System.Drawing.Size(160, 167);
            this.ControlEdgeTable.TabIndex = 0;
            this.ControlEdgeTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlEdgeTable_MouseMove);
            // 
            // ControlContinerPanel
            // 
            this.ControlContinerPanel.Controls.Add(this.FooterLabel);
            this.ControlContinerPanel.Controls.Add(this.ContentsContainerPanel);
            this.ControlContinerPanel.Controls.Add(this.HeaderLabel);
            this.ControlContinerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlContinerPanel.Location = new System.Drawing.Point(11, 12);
            this.ControlContinerPanel.Name = "ControlContinerPanel";
            this.ControlContinerPanel.Size = new System.Drawing.Size(137, 143);
            this.ControlContinerPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(137, 21);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "(Header)";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentsContainerPanel
            // 
            this.ContentsContainerPanel.AutoSize = true;
            this.ContentsContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ContentsContainerPanel.Controls.Add(this.label3);
            this.ContentsContainerPanel.Controls.Add(this.label2);
            this.ContentsContainerPanel.Location = new System.Drawing.Point(3, 24);
            this.ContentsContainerPanel.Name = "ContentsContainerPanel";
            this.ContentsContainerPanel.Size = new System.Drawing.Size(134, 99);
            this.ContentsContainerPanel.TabIndex = 1;
            // 
            // FooterLabel
            // 
            this.FooterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterLabel.Location = new System.Drawing.Point(0, 126);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(137, 17);
            this.FooterLabel.TabIndex = 2;
            this.FooterLabel.Text = "(Footer)";
            this.FooterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // ComponentBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ControlEdgeTable);
            this.Name = "ComponentBase";
            this.Size = new System.Drawing.Size(160, 167);
            this.SizeChanged += new System.EventHandler(this.ComponentBase_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComponentBase_MouseMove);
            this.ControlEdgeTable.ResumeLayout(false);
            this.ControlContinerPanel.ResumeLayout(false);
            this.ControlContinerPanel.PerformLayout();
            this.ContentsContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ControlEdgeTable;
        private System.Windows.Forms.Panel ControlContinerPanel;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Panel ContentsContainerPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HeaderLabel;


    }
}
