namespace sysprog_15._02_2_
{
    partial class Form2
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
            this.captchalbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.captchatb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // captchalbl
            // 
            this.captchalbl.AutoSize = true;
            this.captchalbl.Location = new System.Drawing.Point(347, 101);
            this.captchalbl.Name = "captchalbl";
            this.captchalbl.Size = new System.Drawing.Size(35, 13);
            this.captchalbl.TabIndex = 0;
            this.captchalbl.Text = "label1";
            this.captchalbl.Click += new System.EventHandler(this.captchalbl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "oк";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // captchatb
            // 
            this.captchatb.Location = new System.Drawing.Point(318, 170);
            this.captchatb.Name = "captchatb";
            this.captchatb.Size = new System.Drawing.Size(100, 20);
            this.captchatb.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.captchatb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.captchalbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captchalbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox captchatb;
    }
}