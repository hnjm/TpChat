using Gecko;
using System;
using System.Windows.Forms;

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
                    this.FirstSubmit();
                // NOTE: 
                // + Gender is not available now (so it's disabled in Phase2()). 
                // + hidden feature for admins may appear here.
                else
                    this.SecondSubmit();
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