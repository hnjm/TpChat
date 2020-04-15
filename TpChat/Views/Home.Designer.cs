namespace TpChat.Views
{
    partial class Home
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
            this.browser = new Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.FrameEventsPropagateToMainWindow = false;
            this.browser.Location = new System.Drawing.Point(12, 12);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(744, 443);
            this.browser.TabIndex = 0;
            this.browser.UseHttpActivityObserver = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 465);
            this.Controls.Add(this.browser);
            this.Name = "Home";
            this.Text = "TpChat";
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser browser;
    }
}