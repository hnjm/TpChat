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

            if (this.txtboxUsername.Text != string.Empty)
            {
                if (Data.FirstSubmit)
                {
                    var document = browser.Document;

                    (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                        .Value = txtboxUsername.Text;

                    (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                        .SelectedIndex = this.cmbxGender.SelectedIndex;

                    (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                        .Click();
                }
                // Second Submit
                else
                {
                    Phase2();
                    // ..
                }
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

        
    }
}