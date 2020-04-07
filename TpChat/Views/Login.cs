using Gecko;
using System;
using System.Windows.Forms;
using TpChat.Controllers.Login;

namespace TpChat.Views
{
    public partial class Login : Form
    {
        private bool firstSubmit = true;
        public Login()
        {
            InitializeComponent();
            this.cmbxGender.SelectedItem = cmbxGender.Items[0];
            Xpcom.Initialize("Firefox");
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.browser.Navigate(Controllers.Login.Data.URL);
        }

        #region Helpers - Join Button
        public void CheckLogStatus()
        {
            /*
             * Check if logged-in or not
             * Set Data.Joined
             if logged-in:
                set joined as true;
                Either export the cookie or the browser itself by passing as an arg to Home form;
                Close the window;
             else:
                // no error happens in the first submit. (even the "Member is online" pops in the second time)
                if second time:
                    fetch error from the inner alert
                    see what went wrong
            */
        }
        public void FirstSubmit()
        {
            var document = browser.Document;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                        .Value = txtboxUsername.Text;

            (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                .SelectedIndex = this.cmbxGender.SelectedIndex;

            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();

            this.firstSubmit = false;
            this.Phase2();
        }
        // NOTE: 
        // + Gender is not available now (so it's disabled in Phase2()). 
        // + hidden feature for admins may appear here.
        public void SecondSubmit()
        {
            var document = browser.Document;

            (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                        .Value = this.txtboxPassword.Text;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = txtboxUsername.Text;

            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();
        }
        #endregion

        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkboxShowPass.Checked)
                this.txtboxPassword.UseSystemPasswordChar = false;
            else
                this.txtboxPassword.UseSystemPasswordChar = true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            /* TODO */
            // loader: for loading the website before displaying controllers.
            // loader: when clicking join button
            // Handle: Inner Alert - for example: the member is online OR wrong password .etc.
            // Handle: Pop-up windows
            // Clean : create functions in Assistant for clearing this scope.

            if (this.txtboxUsername.Text != string.Empty)
            {
                if (firstSubmit)
                    FirstSubmit();
                else
                    SecondSubmit();

                this.CheckLogStatus();
            }
            else
                MessageBox.Show("نام کاربری خود را وارد کنید");
        }

        private void Phase2()
        {
            this.label2.Enabled = true;
            this.cmbxGender.Enabled = false;
            this.chkboxShowPass.Enabled = true;
            this.txtboxPassword.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void UserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnJoin.PerformClick();
        }
    }
}