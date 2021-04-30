namespace Management
{
    partial class SearchBRman
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
            this.btnYes = new System.Windows.Forms.Button();
            this.txtSumReturn = new System.Windows.Forms.TextBox();
            this.txtSumLoans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(205, 232);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(119, 44);
            this.btnYes.TabIndex = 9;
            this.btnYes.Text = "确定（&Y）";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtSumReturn
            // 
            this.txtSumReturn.Location = new System.Drawing.Point(255, 145);
            this.txtSumReturn.Name = "txtSumReturn";
            this.txtSumReturn.Size = new System.Drawing.Size(213, 28);
            this.txtSumReturn.TabIndex = 8;
            // 
            // txtSumLoans
            // 
            this.txtSumLoans.Location = new System.Drawing.Point(255, 90);
            this.txtSumLoans.Name = "txtSumLoans";
            this.txtSumLoans.Size = new System.Drawing.Size(213, 28);
            this.txtSumLoans.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "贷款总额（元）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "应还总额（元）：";
            // 
            // SearchBRman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtSumReturn);
            this.Controls.Add(this.txtSumLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchBRman";
            this.Text = "借还查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtSumReturn;
        private System.Windows.Forms.TextBox txtSumLoans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}