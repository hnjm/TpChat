using Gecko;
using Gecko.JQuery;
using Gecko.WebIDL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpChat.Controllers.Login;

/* TODO
 * Set local storage for check boxes & inputs.
 * Add default chat rooms + From google.
   ways to get From google :
    Can use text box to get the address.
    Can Create a new tool form to show the chat room : 
        by searching google like regular browser OR do an overkill and
        add Google API to search (also with the input of google)
 *
*/

namespace TpChat.Views
{
    public partial class Login : Form
    {
        private bool loading = false;
        private bool GuestMode = false;
        private bool OnRealDomain = false;
        private bool RealDomainAvailable = false;
        public Login()
        {
            TryPing();
            InitializeComponent();
            this.picboxLoader.Dock = DockStyle.Fill;
            this.cmbxGender.SelectedItem = cmbxGender.Items[0]; // default gender is boy
            this.txtboxChatAddress.Text = Data.URL; // for now, i use a default chatroom address
            Loader_on();
            InitBrowser();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            const byte loaderY = 150;
            this.picboxLoader.BringToFront();
            this.lblPercentage.BringToFront();
            this.progbarLoader.BringToFront();
            this.lblPercentage.Location = new Point(this.lblPercentage.Location.X, 10);
            this.progbarLoader.Location = new Point(this.progbarLoader.Location.X, loaderY);
        }

        #region Statics
        private void Exit()
        {
            this.Close();
            this.Dispose(true);
            Application.Exit();
            Environment.Exit(1);
        }
        private void ExitTookSoLong(object sender, EventArgs e)
        {
            MessageBox.Show(
                Data.Persian.TOOK_TOO_LONG,
                Data.Persian.ERROR,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            this.Exit();
        }

        //private string FetchMsg()
        //{
        //    var el = browser.Document.GetElementsByClassName(Data.CLASS.MSG_Fetch);
        //    var msg = el.Length > 0 ? el[0].TextContent : "";
        //    JSval("$.msgAlert.close()");
        //    return msg;
        //}
        private void TryPing()
        {
            var hasnet = iTool.Network.iPing.Ping(Data.DOMAIN, 5000).pingable;
            if (!hasnet) // if no ping in 5 seconds
            {
                MessageBox.Show(Data.Persian.BAD_INTERNET,
                                Data.Persian.ERROR,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Exit();
            }
        }
        private void InitBrowser()
        {
            Xpcom.Initialize("Firefox");
            this.browser.Navigate(Data.URL);
            //this.browser.CreateWindow += Browser_CreateWindow;
        }
        private string JSval(string code, bool closeProgram = false)
        {
            string result = string.Empty;
            using (AutoJSContext context = new AutoJSContext(browser.Window))
            {
                try
                {
                    context.EvaluateScript(code, out result);
                }
                catch (GeckoException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (closeProgram)
                        this.Exit();
                }
            }
            return result;
            //browser.Navigate($"javascript:void({code})");
            //Application.DoEvents();
        }

        private void GetRealUrl()
        {
            var loc = browser.Document.GetElementsByTagName("body")[0].GetAttribute("onclick");
            // if real host available and it's not the second time this method's being called.
            if (loc == null && !OnRealDomain)
                this.OnRealDomain = true;
            else
            {
                Data.RealUrl = loc
                    .Split('=')[1]
                    .Replace("'", "")
                    .Replace("\"", "");
                try
                {
                    new Uri(Data.RealUrl);
                    this.RealDomainAvailable = true;
                }
                catch
                {
                    ErrorWrongUrl();
                    this.RealDomainAvailable = false;
                }
            }
        }

        private bool ValidatedUsernameChars() => txtboxUsername.Text.Length > 1;

        private void ErrorWrongUrl()
        {
            MessageBox.Show(
                Data.Persian.ERROR,
                Data.Persian.INVALID_URL,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            this.Exit();
        }
        private void ErrorServerUnavailable()
        {
            MessageBox.Show(
                Data.Persian.SITE_NOT_AVAILABLE,
                Data.Persian.ERROR,
                MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            this.Exit();
        }
        private bool IsServiceUnavailable()
        {
            bool gate = true, service = true;
            var p = browser.Document.GetElementsByTagName("p")[0];
            var body = browser.Document.GetElementsByTagName("body")[0];

            gate = p.TextContent.ToLower().Contains(Data.GatewayTimeout.ToLower());
            service = body.TextContent.ToLower().Contains(Data.ServiceUnavailable.ToLower());

            return gate || service;
        }
        #endregion

        #region Helpers
        private void LoginToChat()
        {
            JSval("login(this)");
            Application.DoEvents();
        }
        private void InitLoginGuest() => JSval(Data.JS.LoginJS_guest);
        private void InitLoginMember() => JSval(Data.JS.LoginJS_member);

        //private bool IsPassHidden()
        //{
        //    string output;
        //    var parent = this.browser.Document.GetElementById(Data.ID.PASSWORD_PARENT)
        //        as GeckoHtmlElement;

        //    output = parent.GetAttribute("style");
        //    output = GetBetween(output, ":", ";");
        //    output = output.ToLower();
        //    return output.Contains("none");
        //}
        //private void CheckJoinStatus()
        //{
        //    if (browser.Document.GetElementById("message") != null)
        //        Data.Joined = true;
        //}

        private void GuestLogin()
        {
            this.InitLoginGuest();
            var document = browser.Document;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = this.txtboxUsername.Text;

            (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                .SelectedIndex = this.cmbxGender.SelectedIndex;

            (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                .Value = "";

            LoginToChat();
        }
        private void MemberLogin()
        {
            this.InitLoginMember();
            var document = browser.Document;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = this.txtboxUsername.Text;

            (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                .SelectedIndex = this.cmbxGender.SelectedIndex;

            (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                .Value = this.txtboxPassword.Text;

            LoginToChat();
        }

        private void Loader_on()
        {
            this.loading = true;
            this.UseWaitCursor = true;
            //this.picboxLoader.Visible = true;
            this.picboxLoader.BringToFront();
            this.lblPercentage.BringToFront();
            this.progbarLoader.BringToFront();
            //
            this.timerLoading.Enabled = true;
        }
        private void Loader_off()
        {
            this.loading = false;
            this.UseWaitCursor = false;
            this.picboxLoader.Visible = false;
            //
            this.timerLoading.Enabled = false;
        }

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
            TryPing();

            if (this.RealDomainAvailable)
            {
                if (ValidatedUsernameChars())
                {
                    if (loading)
                        return;

                    if (IsServiceUnavailable())
                        ErrorServerUnavailable();

                    if (GuestMode)
                        GuestLogin();
                    else
                        MemberLogin();
                }
                else
                    MessageBox.Show(Data.Persian.LEAST_USERNAME_CHARS);

                Loader_off();
            }
            else
                browser.Navigate(Data.URL);
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

        private void Browser_CreateWindow(object sender, GeckoCreateWindowEventArgs e) => e.Cancel = true;
        private void browser_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            this.Loader_on();

            bool joined = e.Uri.LocalPath.ToLower().Contains("chat");
            if (joined)
            {
                this.Close();
                this.Dispose(true);
                new Home(Data.URL).ShowDialog();
            }
        }
        private void browser_ProgressChanged(object sender, GeckoProgressEventArgs e)
        {
            var currentP = iTool.iMath.General.Percentage(e.CurrentProgress, e.MaximumProgress);
            var currentProg = Convert.ToInt32(currentP);

            progbarLoader.Maximum = 101;
            progbarLoader.Minimum = 0;
            if (currentProg <= 100 && currentProg > progbarLoader.Value)
                progbarLoader.Value = currentProg;
            if (progbarLoader.Value > 0)
                lblPercentage.Text = progbarLoader.Value - 1 + " %";
        }
        private void browser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            JSval(Data.JS.PopUpBlock);
            GetRealUrl();

            bool ThereIsUsernameInput = browser.Document.GetElementById("username") != null;
            if (OnRealDomain && ThereIsUsernameInput)
            {
                this.Loader_off();
                progbarLoader.Visible = false;
                lblPercentage.Visible = false;
            }
            else
            {
                GetRealUrl();
            }
        }
    }
}