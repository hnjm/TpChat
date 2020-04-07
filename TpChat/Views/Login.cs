using Gecko;
using System;
using System.Windows.Forms;

namespace TpChat.Views
{
    public partial class Login : Form
    {
        public bool Joined = false;
        public Login()
        {
            InitializeComponent();
            this.cmbxSex.SelectedItem = cmbxSex.Items[0];
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("http://www.persiann24.tk/");
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
            if (this.txtboxUsername.Text != string.Empty)
            {
                MessageBox.Show(this.txtboxUsername.Text);
                this.Joined = true;
                this.Close();
            }
            else
                MessageBox.Show("نام کاربری خود را وارد کنید");
        }

        private void EnablePass()
        {
            this.label2.Enabled = true;
            this.chkboxShowPass.Enabled = true;
            this.txtboxPassword.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}