namespace Management
{
    partial class SearchIO
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumincome = new System.Windows.Forms.TextBox();
            this.txtSumOutput = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "总收入（元）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "总支出（元）：";
            // 
            // txtSumincome
            // 
            this.txtSumincome.Location = new System.Drawing.Point(246, 103);
            this.txtSumincome.Name = "txtSumincome";
            this.txtSumincome.Size = new System.Drawing.Size(213, 28);
            this.txtSumincome.TabIndex = 2;
            // 
            // txtSumOutput
            // 
            this.txtSumOutput.Location = new System.Drawing.Point(246, 158);
            this.txtSumOutput.Name = "txtSumOutput";
            this.txtSumOutput.Size = new System.Drawing.Size(213, 28);
            this.txtSumOutput.TabIndex = 3;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(196, 245);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(119, 44);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "确定（&Y）";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // SearchIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtSumOutput);
            this.Controls.Add(this.txtSumincome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchIO";
            this.Text = "收支查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumincome;
        private System.Windows.Forms.TextBox txtSumOutput;
        private System.Windows.Forms.Button btnYes;
    }
}