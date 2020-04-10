using Gecko;
using Gecko.JQuery;
using Gecko.WebIDL;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpChat.Controllers.Login;

// TODO
/*
 * Set local storage for check boxes & inputs.
*/

namespace TpChat.Views
{
    public partial class Login : Form
    {
        private bool GuestMode = false;
        private Timer timer;
        public Login()
        {
            InitializeComponent();
            this.cmbxGender.SelectedItem = cmbxGender.Items[0];
            Xpcom.Initialize("Firefox");
            this.browser.CreateWindow += Browser_CreateWindow;
            this.browser.Navigate(Data.URL);
        }
        private void Login_Load(object sender, EventArgs e) { }

        #region Statics
        private void JSval(string code, bool closeProgram = false)
        {
            string output;
            using (AutoJSContext context = new AutoJSContext(browser.Window))
            {
                string result;
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

            //browser.Navigate($"javascript:void({code})");
            //Application.DoEvents();
        }
        private bool ValidatedUsernameChars() => txtboxUsername.Text.Length > 1;
        private string FetchMsg()
        {
            JSval("$.msgAlert.close()");
            return browser.Document.GetElementsByClassName(Data.CLASS.MSG_Fetch)[0].TextContent;
        }
        //
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
        private void InitLoginFun()
        {
            // if this app survives ; for further updates =>
            // JS: in login() dont change $.msgAlert() functions.
            // C#: use FetchMsg() for fetching the message's text. (will be closed automatically)
            // Then create Forms for handling the Message.
            // NOTE: login also returns a boolean, it could be the joined or not? idk ,
            // for further updates you could check that out too.
            // By the way, alert does'nt work in $.ajax() scope. must use $.msgAlert().
            JSval(@"
function login(e) { // e = this = Window
    var t = e.username.value;
    return '' == t || ' ' == t ?
        (alert({ text: 'لطفا نام خود را وارد کنید' }), !1) :
        /* Start processing username */
        ($('#ajax_loader').html(
            '<center><img height=\'30\' width=\'30\' src=\'/theme/microblog/images/ajax-loader.gif\'></center>'),
            $.ajax({
                type: 'POST',
                url: url('ajax/login/multi'),
                data: $('#form').serialize(),
                success: function (e) {
                    switch (e) {
                        case 'admins':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url($chat_prefix);
                            break;
                        case 'adminsmob':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url('mobile');
                            break;
                        case 'mobile':
                            top.location.href = url('mobile');
                            break;
                        /* case 'captcha':alert({text: 'شما ربات تشخیص داده شدید لطفا کد تصویر امنیتی را وارد کنید'});document.getElementById('lay_captcha').style.display = 'block';break;*/
                        case 'ok':
                            top.location.href = url($chat_prefix);
                            break;
                        case 'badname':
                            alert('این نام در لیست سیاه قرار دارد');
                            break;
                        case 'benn':
                            alert('شما اجازه ورود به چتروم را ندارید');
                            break;
                        case 'capacity':
                            alert('ظرفیت چت روم پر است');
                            break;
                        case 'running':
                            document.getElementById('lay_pw').style.display = 'block',
                                document.getElementById('password').select(),
                                document.getElementById('lay_gender').style.display = 'none';
                            break;
                        case 'questionError':
                            alert('جواب سئوال امنیتی شما اشتباه است');
                            break;
                        case 'passwh':
                            document.getElementById('lay_pw').style.display = 'block', 
                            document.getElementById('password').select(), 
                            document.getElementById('lay_hide').style.display = 'block', 
                            document.getElementById('lay_gender').style.display = 'none';
                            break;
                        case 'pass':
                            alert('کلمه عبور اشتباه است');
                            break;
                        default:
                            try {
                                var t = jQuery.parseJSON(e);
                                'object' == typeof t ? ($('#lay_pw').slideUp(1e3), 
                                $('#lay_captcha').slideUp(1e3), $('#lay_gender').slideUp(1e3), 
                                $('#lay_hide').slideUp(1e3), 
                                $('#lay_security_question').slideDown(1e3)) : 
                                alert(e);
                            } catch (n) { alert(e) }
                    }
                    $('#ajax_loader').html('')
                }
            }),
            !1
        )
    /* End of Username processing */
} 
            ");
        }
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

        private uint timerInvoked;
        private void GuestCheckLog(object sender, EventArgs e)
        {
            void destroyTimer()
            {
                timer.Enabled = false;
                timer.Dispose();
            }

            if (timerInvoked < 15)
            {
                if (browser.Document.GetElementById(Data.ID.PASSWORD_PARENT) != null)
                {
                    if (!IsPassHidden())
                    {
                        destroyTimer();
                        MessageBox.Show("این نام کاربری ثبت نام شده است", "خطا",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                timerInvoked++;
            }
            else
                destroyTimer();
        }
        private void GuestLogin()
        {
            var document = browser.Document;
            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = this.txtboxUsername.Text;
            //
            JSval("login(this)");
            //
            timerInvoked = 0;
            timer = new Timer();
            timer.Tick += GuestCheckLog;
            timer.Interval = 200;
            timer.Enabled = true;
        }

        private void MemberLogin()
        {

        }

        private void Loader_on() { this.UseWaitCursor = true; }
        private void Loader_off() { this.UseWaitCursor = false; }

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
        }
        private void browser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            this.Loader_off();
            this.InitLoginFun();
            CheckJoinStatus();
            if (Data.Joined)
                MessageBox.Show("شما وارد چت روم شدید");
        }
    }
}