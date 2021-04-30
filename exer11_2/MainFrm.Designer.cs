namespace Management
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSysteMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.收支ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAIO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCIO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudentMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCourseMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewFund = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmNewStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScoreMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewkeep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.常见问题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewAIO = new System.Windows.Forms.ToolStripButton();
            this.tsbStuMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSysteMsg,
            this.收支ToolStripMenuItem,
            this.tsmStudentMsg,
            this.tsmCourseMsg,
            this.tsmScoreMsg,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSysteMsg
            // 
            this.tsmSysteMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmExit});
            this.tsmSysteMsg.Name = "tsmSysteMsg";
            this.tsmSysteMsg.Size = new System.Drawing.Size(104, 28);
            this.tsmSysteMsg.Text = "用户（&S）";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsmLogin.Size = new System.Drawing.Size(236, 30);
            this.tsmLogin.Text = "修改密码";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(236, 30);
            this.tsmExit.Text = "退出";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // 收支ToolStripMenuItem
            // 
            this.收支ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAIO,
            this.tsmCIO});
            this.收支ToolStripMenuItem.Name = "收支ToolStripMenuItem";
            this.收支ToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.收支ToolStripMenuItem.Text = "收支（&I）";
            // 
            // tsmAIO
            // 
            this.tsmAIO.Name = "tsmAIO";
            this.tsmAIO.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmAIO.Size = new System.Drawing.Size(267, 30);
            this.tsmAIO.Text = "添加收支信息";
            this.tsmAIO.Click += new System.EventHandler(this.tsmAIO_Click);
            // 
            // tsmCIO
            // 
            this.tsmCIO.Name = "tsmCIO";
            this.tsmCIO.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCIO.Size = new System.Drawing.Size(267, 30);
            this.tsmCIO.Text = "查询收支信息";
            this.tsmCIO.Click += new System.EventHandler(this.tsmCIO_Click);
            // 
            // tsmStudentMsg
            // 
            this.tsmStudentMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSM,
            this.tsmDI});
            this.tsmStudentMsg.Name = "tsmStudentMsg";
            this.tsmStudentMsg.Size = new System.Drawing.Size(112, 28);
            this.tsmStudentMsg.Text = "储蓄（&M）";
            // 
            // tsmSM
            // 
            this.tsmSM.Name = "tsmSM";
            this.tsmSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmSM.Size = new System.Drawing.Size(268, 30);
            this.tsmSM.Text = "添加储蓄信息";
            this.tsmSM.Click += new System.EventHandler(this.tsmSM_Click);
            // 
            // tsmDI
            // 
            this.tsmDI.Name = "tsmDI";
            this.tsmDI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmDI.Size = new System.Drawing.Size(268, 30);
            this.tsmDI.Text = "查询储蓄信息";
            this.tsmDI.Click += new System.EventHandler(this.tsmDI_Click);
            // 
            // tsmCourseMsg
            // 
            this.tsmCourseMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewFund,
            this.TsmNewStock});
            this.tsmCourseMsg.Name = "tsmCourseMsg";
            this.tsmCourseMsg.Size = new System.Drawing.Size(106, 28);
            this.tsmCourseMsg.Text = "理财（&C）";
            // 
            // tsmNewFund
            // 
            this.tsmNewFund.Name = "tsmNewFund";
            this.tsmNewFund.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmNewFund.Size = new System.Drawing.Size(274, 30);
            this.tsmNewFund.Text = "添加理财信息";
            this.tsmNewFund.Click += new System.EventHandler(this.tsmNewFund_Click);
            // 
            // TsmNewStock
            // 
            this.TsmNewStock.Name = "TsmNewStock";
            this.TsmNewStock.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TsmNewStock.Size = new System.Drawing.Size(274, 30);
            this.TsmNewStock.Text = "查询理财信息  ";
            this.TsmNewStock.Click += new System.EventHandler(this.TsmNewStock_Click);
            // 
            // tsmScoreMsg
            // 
            this.tsmScoreMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewkeep,
            this.tsmNewLoans});
            this.tsmScoreMsg.Name = "tsmScoreMsg";
            this.tsmScoreMsg.Size = new System.Drawing.Size(107, 28);
            this.tsmScoreMsg.Text = "借还（&A）";
            // 
            // tsmNewkeep
            // 
            this.tsmNewkeep.Name = "tsmNewkeep";
            this.tsmNewkeep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.tsmNewkeep.Size = new System.Drawing.Size(265, 30);
            this.tsmNewkeep.Text = "添加借还信息";
            this.tsmNewkeep.Click += new System.EventHandler(this.BRManage_Click);
            // 
            // tsmNewLoans
            // 
            this.tsmNewLoans.Name = "tsmNewLoans";
            this.tsmNewLoans.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmNewLoans.Size = new System.Drawing.Size(265, 30);
            this.tsmNewLoans.Text = "查询借还信息";
            this.tsmNewLoans.Click += new System.EventHandler(this.tsmNewLoans_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常见问题ToolStripMenuItem,
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(108, 28);
            this.tsmHelp.Text = "帮助（&H）";
            // 
            // 常见问题ToolStripMenuItem
            // 
            this.常见问题ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("常见问题ToolStripMenuItem.Image")));
            this.常见问题ToolStripMenuItem.Name = "常见问题ToolStripMenuItem";
            this.常见问题ToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.常见问题ToolStripMenuItem.Text = "常见问题（&Q）";
            this.常见问题ToolStripMenuItem.Click += new System.EventHandler(this.常见问题ToolStripMenuItem_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsmAbout.Image")));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(215, 30);
            this.tsmAbout.Text = "关于（&A）";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewAIO,
            this.tsbStuMsgMag,
            this.toolStripSeparator1,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.toolStripSeparator2,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "常用命令";
            // 
            // tsbNewAIO
            // 
            this.tsbNewAIO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewAIO.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewAIO.Image")));
            this.tsbNewAIO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewAIO.Name = "tsbNewAIO";
            this.tsbNewAIO.Size = new System.Drawing.Size(36, 36);
            this.tsbNewAIO.Text = "i收支";
            this.tsbNewAIO.Click += new System.EventHandler(this.tsmAIO_Click);
            // 
            // tsbStuMsgMag
            // 
            this.tsbStuMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStuMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbStuMsgMag.Image")));
            this.tsbStuMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStuMsgMag.Name = "tsbStuMsgMag";
            this.tsbStuMsgMag.Size = new System.Drawing.Size(36, 36);
            this.tsbStuMsgMag.Text = "i还贷";
            this.tsbStuMsgMag.Click += new System.EventHandler(this.BRManage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCourse.Image")));
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(36, 36);
            this.tsbNewCourse.Text = "i储蓄";
            this.tsbNewCourse.Click += new System.EventHandler(this.tsmSM_Click);
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurMsgMag.Image")));
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(36, 36);
            this.tsbCurMsgMag.Text = "i理财";
            this.tsbCurMsgMag.Click += new System.EventHandler(this.tsmNewFund_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreMsg.Image")));
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(36, 36);
            this.tsbScoreMsg.Text = "i计算";
            this.tsbScoreMsg.Click += new System.EventHandler(this.cauclator_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 574);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "理财管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSysteMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmStudentMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmSM;
        private System.Windows.Forms.ToolStripMenuItem tsmDI;
        private System.Windows.Forms.ToolStripMenuItem tsmCourseMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewFund;
        private System.Windows.Forms.ToolStripMenuItem TsmNewStock;
        private System.Windows.Forms.ToolStripMenuItem tsmScoreMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewAIO;
        private System.Windows.Forms.ToolStripButton tsbStuMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem 收支ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAIO;
        private System.Windows.Forms.ToolStripMenuItem tsmCIO;
        private System.Windows.Forms.ToolStripMenuItem tsmNewkeep;
        private System.Windows.Forms.ToolStripMenuItem tsmNewLoans;
        private System.Windows.Forms.ToolStripMenuItem 常见问题ToolStripMenuItem;
    }
}