﻿namespace Management
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblMain = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMain.Image = ((System.Drawing.Image)(resources.GetObject("lblMain.Image")));
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMain.Location = new System.Drawing.Point(33, 35);
            this.lblMain.Name = "lblMain";
            this.lblMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMain.Size = new System.Drawing.Size(426, 56);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "个人理财管理系统";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(30, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 43);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "用户名：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Image = ((System.Drawing.Image)(resources.GetObject("lblPwd.Image")));
            this.lblPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPwd.Location = new System.Drawing.Point(29, 184);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(140, 56);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "   密码：";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 28);
            this.txtName.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(175, 194);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(178, 28);
            this.txtPwd.TabIndex = 4;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(70, 282);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(104, 41);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "确定（&Y）";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消（&C）";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // login
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
    }
}

