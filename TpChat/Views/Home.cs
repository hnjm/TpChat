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
    public partial class Home : Form
    {
        Gecko.GeckoWebBrowser browser;
        public Home(Gecko.GeckoWebBrowser browser)
        {
            InitializeComponent();
            //
            this.browser = browser;
            browser.Dock = DockStyle.Fill;
            browser.Visible = true;
        }
    }
}
