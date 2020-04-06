using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpChat.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.cmbxSex.SelectedItem = cmbxSex.Items[0];
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
                MessageBox.Show(this.txtboxUsername.Text);
            else
                MessageBox.Show("نام کاربری خود را وارد کنید");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}