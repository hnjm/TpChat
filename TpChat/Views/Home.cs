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
    }
}
