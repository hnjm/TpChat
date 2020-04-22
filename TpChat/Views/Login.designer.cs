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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.browser = new Gecko.GeckoWebBrowser();
            this.chkboxGuest = new System.Windows.Forms.CheckBox();
            this.picboxLoader = new System.Windows.Forms.PictureBox();
            this.progbarLoader = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblChatAddress = new System.Windows.Forms.Label();
            this.txtboxChatAddress = new System.Windows.Forms.TextBox();
            this.btnChatrooms = new System.Windows.Forms.Button();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("2  Yekan", 10F);
            this.txtboxUsername.Location = new System.Drawing.Point(83, 55);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxUsername.Size = new System.Drawing.Size(194, 33);
            this.txtboxUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUsername.Location = new System.Drawing.Point(283, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(83, 26);
            this.lblUsername.TabIndex = 999;
            this.lblUsername.Text = "نام کاربری :\r\n";
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
            this.cmbxGender.Location = new System.Drawing.Point(83, 141);
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
            this.lblPass.Location = new System.Drawing.Point(283, 96);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(70, 26);
            this.lblPass.TabIndex = 999;
            this.lblPass.Text = "رمز عبور :";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.txtboxPassword.Location = new System.Drawing.Point(83, 94);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxPassword.Size = new System.Drawing.Size(194, 27);
            this.txtboxPassword.TabIndex = 3;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Font = new System.Drawing.Font("B Mitra", 12F);
            this.chkboxShowPass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.chkboxShowPass.Location = new System.Drawing.Point(14, 92);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(64, 32);
            this.chkboxShowPass.TabIndex = 4;
            this.chkboxShowPass.Text = "رویت";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            this.chkboxShowPass.CheckedChanged += new System.EventHandler(this.chkboxShowPass_CheckedChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnJoin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("IRTehran", 10F);
            this.btnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoin.Location = new System.Drawing.Point(202, 137);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 43);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "ورود";
            this.btnJoin.UseVisualStyleBackColor = false;
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
            this.btnHelp.Location = new System.Drawing.Point(342, 141);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 35);
            this.btnHelp.TabIndex = 1002;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // browser
            // 
            this.browser.FrameEventsPropagateToMainWindow = false;
            this.browser.Location = new System.Drawing.Point(14, 281);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(714, 257);
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
            this.chkboxGuest.Location = new System.Drawing.Point(14, 56);
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
            this.picboxLoader.Location = new System.Drawing.Point(361, 231);
            this.picboxLoader.Name = "picboxLoader";
            this.picboxLoader.Size = new System.Drawing.Size(30, 23);
            this.picboxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLoader.TabIndex = 1005;
            this.picboxLoader.TabStop = false;
            this.picboxLoader.Visible = false;
            // 
            // progbarLoader
            // 
            this.progbarLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progbarLoader.Location = new System.Drawing.Point(14, 231);
            this.progbarLoader.Name = "progbarLoader";
            this.progbarLoader.Size = new System.Drawing.Size(341, 23);
            this.progbarLoader.TabIndex = 1006;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("MRT_AridiKoufi", 15F);
            this.lblPercentage.Location = new System.Drawing.Point(167, 211);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(34, 36);
            this.lblPercentage.TabIndex = 1007;
            this.lblPercentage.Text = "0%";
            // 
            // lblChatAddress
            // 
            this.lblChatAddress.AutoSize = true;
            this.lblChatAddress.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.lblChatAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChatAddress.Location = new System.Drawing.Point(278, 15);
            this.lblChatAddress.Name = "lblChatAddress";
            this.lblChatAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChatAddress.Size = new System.Drawing.Size(105, 27);
            this.lblChatAddress.TabIndex = 1009;
            this.lblChatAddress.Text = "آدرس چت روم :";
            // 
            // txtboxChatAddress
            // 
            this.txtboxChatAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtboxChatAddress.Location = new System.Drawing.Point(54, 17);
            this.txtboxChatAddress.Name = "txtboxChatAddress";
            this.txtboxChatAddress.ReadOnly = true;
            this.txtboxChatAddress.Size = new System.Drawing.Size(223, 24);
            this.txtboxChatAddress.TabIndex = 1010;
            // 
            // btnChatrooms
            // 
            this.btnChatrooms.Location = new System.Drawing.Point(14, 17);
            this.btnChatrooms.Name = "btnChatrooms";
            this.btnChatrooms.Size = new System.Drawing.Size(34, 23);
            this.btnChatrooms.TabIndex = 1011;
            this.btnChatrooms.Text = "=";
            this.btnChatrooms.UseVisualStyleBackColor = true;
            this.btnChatrooms.Visible = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 100000;
            this.timerLoading.Tick += new System.EventHandler(this.ExitTookSoLong);
            // 
            // Login
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.picboxLoader);
            this.Controls.Add(this.btnChatrooms);
            this.Controls.Add(this.txtboxChatAddress);
            this.Controls.Add(this.lblChatAddress);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progbarLoader);
            this.Controls.Add(this.chkboxGuest);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.chkboxShowPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.cmbxGender);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtboxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cmbxGender;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.CheckBox chkboxShowPass;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnHelp;
        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.CheckBox chkboxGuest;
        private System.Windows.Forms.PictureBox picboxLoader;
        private System.Windows.Forms.ProgressBar progbarLoader;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblChatAddress;
        private System.Windows.Forms.TextBox txtboxChatAddress;
        private System.Windows.Forms.Button btnChatrooms;
        private System.Windows.Forms.Timer timerLoading;
    }
}