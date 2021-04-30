namespace Management
{
    partial class password
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
            this.txtmpsd = new System.Windows.Forms.TextBox();
            this.txtpsd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmpsd
            // 
            this.txtmpsd.Location = new System.Drawing.Point(174, 122);
            this.txtmpsd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmpsd.Name = "txtmpsd";
            this.txtmpsd.Size = new System.Drawing.Size(154, 28);
            this.txtmpsd.TabIndex = 11;
            // 
            // txtpsd
            // 
            this.txtpsd.Location = new System.Drawing.Point(174, 77);
            this.txtpsd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpsd.Name = "txtpsd";
            this.txtpsd.Size = new System.Drawing.Size(154, 28);
            this.txtpsd.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "修改密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "确认密码：";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(127, 214);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(101, 41);
            this.btnYes.TabIndex = 13;
            this.btnYes.Text = "确认（&Y）";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "*两次密码不一致！";
            this.label1.Visible = false;
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmpsd);
            this.Controls.Add(this.txtpsd);
            this.Controls.Add(this.label6);
            this.Name = "password";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmpsd;
        private System.Windows.Forms.TextBox txtpsd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label1;
    }
}