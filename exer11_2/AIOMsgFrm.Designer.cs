namespace Management
{
    partial class AIOMsgFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtIncomedate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIYes = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbooutcome = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtoutcomedate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usertxtbox = new System.Windows.Forms.TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.txtMoneyBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtmoney);
            this.tabPage1.Controls.Add(this.cboInput);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtIncomedate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnIYes);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 374);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "收入信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboInput
            // 
            this.cboInput.FormattingEnabled = true;
            this.cboInput.Items.AddRange(new object[] {
            "微信",
            "支付宝",
            "银行卡",
            "现金"});
            this.cboInput.Location = new System.Drawing.Point(304, 59);
            this.cboInput.Name = "cboInput";
            this.cboInput.Size = new System.Drawing.Size(121, 26);
            this.cboInput.TabIndex = 8;
            this.cboInput.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "收入类别：";
            // 
            // dtIncomedate
            // 
            this.dtIncomedate.Location = new System.Drawing.Point(304, 168);
            this.dtIncomedate.Name = "dtIncomedate";
            this.dtIncomedate.Size = new System.Drawing.Size(183, 28);
            this.dtIncomedate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "收入金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "收入时间：";
            // 
            // btnIYes
            // 
            this.btnIYes.Location = new System.Drawing.Point(290, 284);
            this.btnIYes.Name = "btnIYes";
            this.btnIYes.Size = new System.Drawing.Size(103, 37);
            this.btnIYes.TabIndex = 12;
            this.btnIYes.Text = "确定(&Y)";
            this.btnIYes.UseVisualStyleBackColor = true;
            this.btnIYes.Click += new System.EventHandler(this.btnIYes_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(304, 114);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 28);
            this.txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(203, 117);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 18);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "收入账户：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtMoneyBox);
            this.tabPage3.Controls.Add(this.cbooutcome);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dtoutcomedate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.usertxtbox);
            this.tabPage3.Controls.Add(this.userlabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(720, 374);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "支出信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbooutcome
            // 
            this.cbooutcome.FormattingEnabled = true;
            this.cbooutcome.Items.AddRange(new object[] {
            "微信",
            "支付宝",
            "银行卡",
            "现金"});
            this.cbooutcome.Location = new System.Drawing.Point(311, 42);
            this.cbooutcome.Name = "cbooutcome";
            this.cbooutcome.Size = new System.Drawing.Size(121, 26);
            this.cbooutcome.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "支出类别：";
            // 
            // dtoutcomedate
            // 
            this.dtoutcomedate.Location = new System.Drawing.Point(311, 151);
            this.dtoutcomedate.Name = "dtoutcomedate";
            this.dtoutcomedate.Size = new System.Drawing.Size(183, 28);
            this.dtoutcomedate.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "支出金额：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "支出时间：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "确定(&Y)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usertxtbox
            // 
            this.usertxtbox.Location = new System.Drawing.Point(311, 97);
            this.usertxtbox.Name = "usertxtbox";
            this.usertxtbox.Size = new System.Drawing.Size(199, 28);
            this.usertxtbox.TabIndex = 21;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(210, 100);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(98, 18);
            this.userlabel.TabIndex = 18;
            this.userlabel.Text = "支出账户：";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(304, 220);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(129, 28);
            this.txtmoney.TabIndex = 18;
            // 
            // txtMoneyBox
            // 
            this.txtMoneyBox.Location = new System.Drawing.Point(311, 203);
            this.txtMoneyBox.Name = "txtMoneyBox";
            this.txtMoneyBox.Size = new System.Drawing.Size(116, 28);
            this.txtMoneyBox.TabIndex = 28;
            // 
            // AIOMsgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "AIOMsgFrm";
            this.Text = "添加收支信息";
            this.Load += new System.EventHandler(this.CourseMsgFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnIYes;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInput;
        private System.Windows.Forms.DateTimePicker dtIncomedate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbooutcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtoutcomedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usertxtbox;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.TextBox txtMoneyBox;
    }
}