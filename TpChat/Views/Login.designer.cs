﻿namespace TpChat.Views
{
    partial class Login
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
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.browser = new Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("2  Yekan", 10F);
            this.txtboxUsername.Location = new System.Drawing.Point(82, 15);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxUsername.Size = new System.Drawing.Size(194, 33);
            this.txtboxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :\r\n";
            // 
            // cmbxGender
            // 
            this.cmbxGender.BackColor = System.Drawing.Color.White;
            this.cmbxGender.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxGender.Font = new System.Drawing.Font("IRMitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbxGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxGender.FormattingEnabled = true;
            this.cmbxGender.ItemHeight = 24;
            this.cmbxGender.Items.AddRange(new object[] {
            "  پسر",
            "  دختر"});
            this.cmbxGender.Location = new System.Drawing.Point(82, 101);
            this.cmbxGender.MaxDropDownItems = 2;
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxGender.Size = new System.Drawing.Size(63, 32);
            this.cmbxGender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(282, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور :";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Enabled = false;
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.txtboxPassword.Location = new System.Drawing.Point(82, 54);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxPassword.Size = new System.Drawing.Size(194, 27);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Enabled = false;
            this.chkboxShowPass.Font = new System.Drawing.Font("B Mitra", 11F);
            this.chkboxShowPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chkboxShowPass.Location = new System.Drawing.Point(14, 53);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(62, 31);
            this.chkboxShowPass.TabIndex = 999;
            this.chkboxShowPass.Text = "رویت";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            this.chkboxShowPass.CheckedChanged += new System.EventHandler(this.chkboxShowPass_CheckedChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("IRTehran", 10F);
            this.btnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoin.Location = new System.Drawing.Point(201, 97);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 43);
            this.btnJoin.TabIndex = 1001;
            this.btnJoin.Text = "ورود";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnHelp.Location = new System.Drawing.Point(324, 101);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 35);
            this.btnHelp.TabIndex = 1002;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // browser
            // 
            this.browser.FrameEventsPropagateToMainWindow = false;
            this.browser.Location = new System.Drawing.Point(12, 150);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(362, 260);
            this.browser.TabIndex = 1003;
            this.browser.UseHttpActivityObserver = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 422);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.chkboxShowPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.cmbxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxUsername);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TpChat - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.CheckBox chkboxShowPass;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnHelp;
        private Gecko.GeckoWebBrowser browser;
    }
}