using Gecko;
using System;
using System.Windows.Forms;
using TpChat.Controllers.Login;

namespace TpChat.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.cmbxGender.SelectedItem = cmbxGender.Items[0];
            Xpcom.Initialize("Firefox");
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.browser.Navigate(Data.URL);
        }

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
            // set a loader for loading the website before displaying controllers.
            // Handle Inner Alert - for example: the member is online OR wrong password .etc.

            if (this.txtboxUsername.Text != string.Empty)
            {
                var document = browser.Document;

                if (Data.FirstSubmit)
                {
                    (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                        .Value = txtboxUsername.Text;

                    (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                        .SelectedIndex = this.cmbxGender.SelectedIndex;

                    (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                        .Click();

                    Data.FirstSubmit = false;
                    Phase2();
                }
                // NOTE: 
                // + Gender is not available now (so it's disabled in Phase2()). 
                // + hidden feature for admins may appear here.
                else
                {
                    (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                        .Value = this.txtboxPassword.Text;

                    (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                        .Value = txtboxUsername.Text;

                    (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                        .Click();
                }
                Assistant.CheckLogStatus(document);
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