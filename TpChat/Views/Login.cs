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
        private bool GuestMode = false;
        public Login()
        {
            InitializeComponent();
            this.picboxLoader.Dock = DockStyle.Fill;
            this.cmbxGender.SelectedItem = cmbxGender.Items[0];
            this.lblChatAddress.Text = Data.URL;
            Loader_on();
            var minnet = iTool.Network.iPing.Ping(Data.DOMAIN, 4000).pingable;
            if (!minnet)
                BadNet();
            else
                MessageBox.Show("Conncetion verified");

            Xpcom.Initialize("Firefox");
            this.browser.CreateWindow += Browser_CreateWindow;
            this.browser.Navigate(Data.URL);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            const byte loaderY = 150;
            this.lblPercentage.Location = new System.Drawing.Point(this.lblPercentage.Location.X, 20);
            this.progbarLoader.Location = new System.Drawing.Point(this.progbarLoader.Location.X, loaderY);
        }

        #region Statics
        private void Exit()
        {
            this.Close();
            this.Dispose();
            Application.Exit();
            Environment.Exit(1);
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
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
            }
            return result;
            //browser.Navigate($"javascript:void({code})");
            //Application.DoEvents();
        }
        private bool ValidatedUsernameChars() => txtboxUsername.Text.Length > 1;
        private string FetchMsg()
        {
            var el = browser.Document.GetElementsByClassName(Data.CLASS.MSG_Fetch);
            var msg = el.Length > 0 ? el[0].TextContent : "";
            JSval("$.msgAlert.close()");
            return msg;
        }
        private void BadNet()
        {
            string badnettxt = "خطای ارتباط! دلایل خطا میتواند از گزینه های زیر باشد" +
                '\n' + "ارتباط با سایت امکان پذیر نمی باشد" +
                '\n' + "اینترنت شما ضعیف یا قطع می باشد";
            MessageBox.Show(badnettxt, "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Exit();
        }

        private static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region Helpers
        private void LoginToChat()
        {
            JSval("login(this)");
            Application.DoEvents();
        }
        private void InitLoginGuest() => JSval(Data.LoginJS_guest);
        private void InitLoginMember() => JSval(Data.LoginJS_member);

        private bool IsPassHidden()
        {
            string output;
            var parent = this.browser.Document.GetElementById(Data.ID.PASSWORD_PARENT)
                as GeckoHtmlElement;

            output = parent.GetAttribute("style");
            output = GetBetween(output, ":", ";");
            output = output.ToLower();
            return output.Contains("none");
        }
        private void CheckJoinStatus()
        {
            if (browser.Document.GetElementById("message") != null)
                Data.Joined = true;
        }

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
            this.UseWaitCursor = true;
            this.picboxLoader.Visible = true;
            this.lblChatAddress.Visible = false;
        }
        private void Loader_off()
        {
            this.UseWaitCursor = false;
            this.picboxLoader.Visible = false;
            this.lblChatAddress.Visible = true;
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

            if (ValidatedUsernameChars())
            {
                if (GuestMode)
                    GuestLogin();
                else
                    MemberLogin();
            }
            else
                MessageBox.Show("حداقل طول نام کاربری ۲ حرف می باشد");

            Loader_off();
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
                MessageBox.Show("Navigating to the chat room");
        }
        private void browser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            this.Loader_off();
            progbarLoader.Visible = false;
            lblPercentage.Visible = false;
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
                lblPercentage.Text = progbarLoader.Value - 1 + "%";
        }
    }
}