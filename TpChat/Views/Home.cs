using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpChat.Controllers.Login;

namespace TpChat.Views
{
    public partial class Home : Form
    {
        public Home(string ChatroomAddress)
        {
            InitializeComponent();
            this.browser.Navigate(ChatroomAddress);
        }

        private void browser_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            // if navigating to the login page ... either exit or show login + mbox(you have logged out)
            if (e.Uri.LocalPath == "/")
                MessageBox.Show(e.Uri.LocalPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }
    }
}
