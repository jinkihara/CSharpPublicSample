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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.lblClientForm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClientControl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEventArgs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.componentBase2 = new SysMngToolDemo.Components.ComponentBase();
            this.componentBase1 = new SysMngToolDemo.Components.ComponentBase();
            this.lblEventToScreen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "スクリーン座標";
            // 
            // lblScreen
            // 
            this.lblScreen.Location = new System.Drawing.Point(290, 205);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(100, 23);
            this.lblScreen.TabIndex = 3;
            this.lblScreen.Text = "{X=xx, Y=yy}";
            // 
            // lblClientForm
            // 
            this.lblClientForm.Location = new System.Drawing.Point(290, 228);
            this.lblClientForm.Name = "lblClientForm";
            this.lblClientForm.Size = new System.Drawing.Size(100, 23);
            this.lblClientForm.TabIndex = 5;
            this.lblClientForm.Text = "{X=xx, Y=yy}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "クライアント座標（フォーム）";
            // 
            // lblClientControl
            // 
            this.lblClientControl.Location = new System.Drawing.Point(290, 250);
            this.lblClientControl.Name = "lblClientControl";
            this.lblClientControl.Size = new System.Drawing.Size(100, 23);
            this.lblClientControl.TabIndex = 7;
            this.lblClientControl.Text = "{X=xx, Y=yy}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "クライアント座標（コントロール）";
            // 
            // lblEventArgs
            // 
            this.lblEventArgs.Location = new System.Drawing.Point(290, 273);
            this.lblEventArgs.Name = "lblEventArgs";
            this.lblEventArgs.Size = new System.Drawing.Size(100, 23);
            this.lblEventArgs.TabIndex = 9;
            this.lblEventArgs.Text = "{X=xx, Y=yy}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "イベントArgs";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(387, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 71);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // componentBase2
            // 
            this.componentBase2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentBase2.Location = new System.Drawing.Point(342, 45);
            this.componentBase2.Name = "componentBase2";
            this.componentBase2.Size = new System.Drawing.Size(98, 97);
            this.componentBase2.TabIndex = 1;
            // 
            // componentBase1
            // 
            this.componentBase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentBase1.Location = new System.Drawing.Point(108, 57);
            this.componentBase1.Name = "componentBase1";
            this.componentBase1.Size = new System.Drawing.Size(126, 101);
            this.componentBase1.TabIndex = 0;
            // 
            // lblEventToScreen
            // 
            this.lblEventToScreen.Location = new System.Drawing.Point(290, 296);
            this.lblEventToScreen.Name = "lblEventToScreen";
            this.lblEventToScreen.Size = new System.Drawing.Size(100, 23);
            this.lblEventToScreen.TabIndex = 12;
            this.lblEventToScreen.Text = "{X=xx, Y=yy}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "イベントArgs⇒スクリーン";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 511);
            this.Controls.Add(this.lblEventToScreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEventArgs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblClientControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblClientForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.componentBase2);
            this.Controls.Add(this.componentBase1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ComponentBase componentBase1;
        private Components.ComponentBase componentBase2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label lblClientForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClientControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEventArgs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEventToScreen;
        private System.Windows.Forms.Label label5;
    }
}