namespace TpChat.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.browser = new Gecko.GeckoWebBrowser();
            this.chkboxGuest = new System.Windows.Forms.CheckBox();
            this.picboxLoader = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("2  Yekan", 10F);
            this.txtboxUsername.Location = new System.Drawing.Point(83, 15);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxUsername.Size = new System.Drawing.Size(194, 33);
            this.txtboxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 999;
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
            this.cmbxGender.Location = new System.Drawing.Point(83, 101);
            this.cmbxGender.MaxDropDownItems = 2;
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxGender.Size = new System.Drawing.Size(63, 32);
            this.cmbxGender.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPass.Location = new System.Drawing.Point(283, 58);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(70, 26);
            this.lblPass.TabIndex = 999;
            this.lblPass.Text = "رمز عبور :";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.txtboxPassword.Location = new System.Drawing.Point(83, 54);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxPassword.Size = new System.Drawing.Size(194, 27);
            this.txtboxPassword.TabIndex = 3;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Font = new System.Drawing.Font("B Mitra", 11F);
            this.chkboxShowPass.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkboxShowPass.Location = new System.Drawing.Point(20, 56);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(62, 31);
            this.chkboxShowPass.TabIndex = 4;
            this.chkboxShowPass.Text = "رویت";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            this.chkboxShowPass.CheckedChanged += new System.EventHandler(this.chkboxShowPass_CheckedChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("IRTehran", 10F);
            this.btnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoin.Location = new System.Drawing.Point(202, 97);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 43);
            this.btnJoin.TabIndex = 6;
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
            this.btnHelp.Location = new System.Drawing.Point(312, 101);
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
            this.browser.Size = new System.Drawing.Size(670, 480);
            this.browser.TabIndex = 1003;
            this.browser.UseHttpActivityObserver = false;
            this.browser.Navigating += new System.EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(this.browser_Navigating);
            this.browser.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.browser_DocumentCompleted);
            this.browser.ProgressChanged += new System.EventHandler<Gecko.GeckoProgressEventArgs>(this.browser_ProgressChanged);
            // 
            // chkboxGuest
            // 
            this.chkboxGuest.AutoSize = true;
            this.chkboxGuest.Font = new System.Drawing.Font("B Mitra", 11F);
            this.chkboxGuest.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkboxGuest.Location = new System.Drawing.Point(14, 16);
            this.chkboxGuest.Name = "chkboxGuest";
            this.chkboxGuest.Size = new System.Drawing.Size(68, 31);
            this.chkboxGuest.TabIndex = 2;
            this.chkboxGuest.Text = "مهمان";
            this.chkboxGuest.UseVisualStyleBackColor = true;
            this.chkboxGuest.CheckedChanged += new System.EventHandler(this.chkboxGuest_CheckedChanged);
            // 
            // picboxLoader
            // 
            this.picboxLoader.Image = ((System.Drawing.Image)(resources.GetObject("picboxLoader.Image")));
            this.picboxLoader.Location = new System.Drawing.Point(166, 101);
            this.picboxLoader.Name = "picboxLoader";
            this.picboxLoader.Size = new System.Drawing.Size(30, 23);
            this.picboxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLoader.TabIndex = 1005;
            this.picboxLoader.TabStop = false;
            this.picboxLoader.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(391, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 23);
            this.progressBar1.TabIndex = 1006;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(510, 22);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(28, 17);
            this.lblPercentage.TabIndex = 1007;
            this.lblPercentage.Text = "0%";
            // 
            // Login
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 637);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picboxLoader);
            this.Controls.Add(this.chkboxGuest);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.chkboxShowPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.cmbxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TpChat - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxGender;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.CheckBox chkboxShowPass;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnHelp;
        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.CheckBox chkboxGuest;
        private System.Windows.Forms.PictureBox picboxLoader;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercentage;
    }
}