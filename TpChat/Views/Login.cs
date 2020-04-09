using Gecko;
using Gecko.JQuery;
using Gecko.WebIDL;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpChat.Controllers.Login;

// TODO
/*
 * Set local storage for check boxes & inputs.
*/

namespace TpChat.Views
{
    public partial class Login : Form
    {
        private bool GuestMode = false;
        private Timer timer = new Timer();
        public Login()
        {
            InitializeComponent();
            this.cmbxGender.SelectedItem = cmbxGender.Items[0];
            Xpcom.Initialize("Firefox");
            this.browser.Navigate(Data.URL);
        }
        private void Login_Load(object sender, EventArgs e) { }

        #region Statics
        private static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region Helpers
        private bool IsPassHidden()
        {
            string output;
            var parent = this.browser.Document.GetElementById(Data.ID.PASSWORD_PARENT)
                as GeckoHtmlElement;

            output = parent.GetAttribute("style");
            output = GetBetween(output, ":", ";");
            output = output.ToLower();
            return output.Contains("none");
        }

        private void CheckJoinStatus()
        {
            //if (browser.Document.GetElementById("message") != null)
            //{
            //    Data.Joined = true;
            //    MessageBox.Show($"Joined");
            //    // this.Close();
            //    // Export Cookie (or browser)
            //}
            //else
            //    if (!firstSubmit)
            //    MessageBox.Show("Something went wrong. failed to login.");
        }
        private void SecondSubmit()
        {
            var document = browser.Document;

            (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                        .Value = this.txtboxPassword.Text;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = txtboxUsername.Text;

            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();
        }

        private uint ElapsedTime;
        private void GuestCheckLog(object sender, EventArgs e)
        {
            CheckJoinStatus();
            if (this.ElapsedTime < 5000)
            {
                if (Data.Joined)
                {
                    timer.Stop();
                    MessageBox.Show("با موفقیت وارد چت روم شدید");
                    // this.Close();
                    // Application.Run(new Home());
                }
                //else if (!IsPassHidden())
                //{
                //    timer.Stop();
                //    MessageBox.Show("این نام کاربری ثبت نام شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else
                    this.ElapsedTime += 200;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("اینترنت خود را چک کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
        }
        private void GuestLogin()
        {
            var document = browser.Document;
            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = this.txtboxUsername.Text;
            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();
            //
            this.ElapsedTime = 0;
            this.timer.Tick += GuestCheckLog;
            this.timer.Interval = 200;
            this.timer.Start();
        }
        private void MemberLogin()
        {

        }

        private void Loader_on() { this.UseWaitCursor = true; }
        private void Loader_off() { this.UseWaitCursor = false; }

        private void ShowPassForm()
        {
            this.lblPass.Enabled = true;
            this.chkboxShowPass.Enabled = true;
            this.txtboxPassword.Enabled = true;
        }
        private void HidePassForm()
        {
            this.lblPass.Enabled = false;
            this.chkboxShowPass.Enabled = false;
            this.txtboxPassword.Enabled = false;
        }
        #endregion

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Loader_on();
            if (this.txtboxUsername.Text.Length > 1)
            {
                if (GuestMode)
                    GuestLogin();
                else
                    MemberLogin();
            }
            else
                MessageBox.Show("حداقل طول نام کاربری ۲ حرف می باشد");
            Loader_off();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void chkboxGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxGuest.Checked)
            {
                GuestMode = true;
                this.HidePassForm();
            }
            else
            {
                GuestMode = false;
                this.ShowPassForm();
            }
        }
        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkboxShowPass.Checked)
                this.txtboxPassword.UseSystemPasswordChar = false;
            else
                this.txtboxPassword.UseSystemPasswordChar = true;
        }

        private void browser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            this.Loader_off();
        }
        private void browser_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            this.Loader_on();
        }
    }
}