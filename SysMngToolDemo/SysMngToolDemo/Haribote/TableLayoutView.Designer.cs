namespace SysMngToolDemo.Haribote
{
    partial class TableLayoutView
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
            this.lblTableName = new System.Windows.Forms.Label();
            this.dgrTableLayout = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTableLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(0, 1);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(217, 18);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "label1";
            // 
            // dgrTableLayout
            // 
            this.dgrTableLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTableLayout.Location = new System.Drawing.Point(12, 34);
            this.dgrTableLayout.Name = "dgrTableLayout";
            this.dgrTableLayout.RowTemplate.Height = 21;
            this.dgrTableLayout.Size = new System.Drawing.Size(614, 366);
            this.dgrTableLayout.TabIndex = 1;
            // 
            // TableLayoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.dgrTableLayout);
            this.Controls.Add(this.lblTableName);
            this.Name = "TableLayoutView";
            this.Text = "TableLayoutView";
            ((System.ComponentModel.ISupportInitialize)(this.dgrTableLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.DataGridView dgrTableLayout;
    }
}