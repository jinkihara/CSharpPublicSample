namespace SysMngToolDemo
{
    partial class MainForm
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
            this.componentBase1 = new SysMngToolDemo.Components.ComponentBase();
            this.componentBase2 = new SysMngToolDemo.Components.ComponentBase();
            this.SuspendLayout();
            // 
            // componentBase1
            // 
            this.componentBase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentBase1.Location = new System.Drawing.Point(108, 57);
            this.componentBase1.Name = "componentBase1";
            this.componentBase1.Size = new System.Drawing.Size(126, 101);
            this.componentBase1.TabIndex = 0;
            // 
            // componentBase2
            // 
            this.componentBase2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentBase2.Location = new System.Drawing.Point(342, 45);
            this.componentBase2.Name = "componentBase2";
            this.componentBase2.Size = new System.Drawing.Size(98, 97);
            this.componentBase2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 511);
            this.Controls.Add(this.componentBase2);
            this.Controls.Add(this.componentBase1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ComponentBase componentBase1;
        private Components.ComponentBase componentBase2;
    }
}