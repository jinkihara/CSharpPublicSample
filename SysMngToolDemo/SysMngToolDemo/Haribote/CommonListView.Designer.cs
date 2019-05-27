namespace SysMngToolDemo.Haribote
{
    partial class CommonListView
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
            this.lblListName = new System.Windows.Forms.Label();
            this.dgrTableLayout = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTableLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListName
            // 
            this.lblListName.Location = new System.Drawing.Point(0, 1);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(217, 18);
            this.lblListName.TabIndex = 0;
            this.lblListName.Text = "label1";
            // 
            // dgrTableLayout
            // 
            this.dgrTableLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTableLayout.Location = new System.Drawing.Point(12, 22);
            this.dgrTableLayout.Name = "dgrTableLayout";
            this.dgrTableLayout.RowTemplate.Height = 21;
            this.dgrTableLayout.Size = new System.Drawing.Size(614, 420);
            this.dgrTableLayout.TabIndex = 1;
            // 
            // CommonListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.dgrTableLayout);
            this.Controls.Add(this.lblListName);
            this.Name = "CommonListView";
            this.Text = "CommonListView";
            ((System.ComponentModel.ISupportInitialize)(this.dgrTableLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.DataGridView dgrTableLayout;
    }
}