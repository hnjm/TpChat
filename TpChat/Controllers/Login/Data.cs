using System;

namespace TpChat.Controllers.Login
{
    /* Alternative for taking care of evnets
     * use console.log() instead and capture the message then
       by ConsoleMessage event of geckofx.
    */
    /* Considerale gecko Events:
     * < misc >
     * ConsoleMessage
     * CreateWindow 
     * WindowClosed
    */
    /* Todo
     * Replace type of url (string) to Url.
     * Url shouldn't be constant. user will decide.
    */
    public static class Data
    {
        public const string GatewayTimeout = "Gateway Timeout";
        public const string ServiceUnavailable = "Service unavailable";

        public static bool Joined = false;
        // Real url
        // < body onclick = "location.href='http://www.sahra777.tk'" >
        // Becomes :
        // < body >
        //
        //public static string URL = "http://www.nazchat.org/";
        public static string URL = "http://www.persain777.ml/";
        public static string DOMAIN = new Uri(URL).Host;
        //public static string URL_banned { get { return URL + "benned"; } }

        public static string RealUrl = string.Empty;

        public struct ID
        {
            public const string USERNAME = "username";
            public const string PASSWORD = "password";
            public const string GENDER = "gender";
            public const string BUTTON = "submit_button";
            public const string PASSWORD_PARENT = "lay_pw";
            // there is also this feature -hide- for admins:
            // <input name="hide" value="1" type="checkbox">
        }
        public struct CLASS
        {
            public const string MSG_Fetch = "msgAlert_content";
        }
        public struct Persian
        {
            public const string ERROR = "خطا";
            public const string TOOK_TOO_LONG = "مدت زیادی طول کشید";
            public const string LEAST_USERNAME_CHARS = "حداقل طول نام کاربری ۲ حرف می باشد";
            public static readonly string BAD_INTERNET = "خطای ارتباط! دلایل خطا میتواند از گزینه های زیر باشد" +
                   '\n' + "ارتباط با سایت امکان پذیر نمی باشد" +
                   '\n' + "اینترنت شما ضعیف یا قطع می باشد";
            public static readonly string SITE_NOT_AVAILABLE = "سایت در حال حاضر در دسترس نمی باشد" + '\n' +
                "لطفا لحظاتی صبر کنید و مجددا امتحان کنید";
            public static readonly string INVALID_URL = "آدرس سایت اشتباه است." + '\n' +
                "آیا مطمئن اید که این آدرس صحیح می باشد؟";
        }

        // TODO:
        // alerts for other events.

        public struct JS
        {
            public const string PopUpBlock = "window.open = (url, windowName, windowFeatures) => console.log(url)";

            public const string LoginJS_guest = @"
function login(e) {
    1 == firstlogin && ($('#password').val(''), firstlogin = !1);
    var t = e.username.value;
    return ($('#ajax_loader').html('<center><img height=\'30\' width=\'30\' src=\'/theme/microblog/images/ajax-loader.gif\'></center>'),
            $.ajax({
                type: 'POST',
                url: url('ajax/login/multi'),
                data: $('#form').serialize(),
                success: function (e) {
                    switch (e) {
                        /* case 'captcha':$.msgAlert({text: 'شما ربات تشخیص داده شدید لطفا کد تصویر امنیتی را وارد کنید'});document.getElementById('lay_captcha').style.display = 'block';break;*/

                        // admins
                        case 'admins':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url($chat_prefix);
                            break;
                        // admins mobile - not important
                        case 'adminsmob':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url('mobile');
                            break;
                        // mobile - not important
                        case 'mobile':
                            top.location.href = url('mobile');
                            break;
                        // Joined
                        case 'ok':
                            top.location.href = url($chat_prefix);
                            break;
                        // BlackListed name
                        case 'badname':
                            window.alert('این نام مناسب نمی باشد');
                            break;
                        // Banned
                        case 'benn':
                            window.alert('به دلیل اخراج شدن شما اجازه ی ورود ندارید');
                            break;
                        // Capacity
                        case 'capacity':
                            window.alert('ظرفیت چت روم پر می باشد');
                            break;
                        // Member Loging : Step 2 
                        case 'running':
                            window.alert('این نام کاربری ثبت نام شده است');
                            document.getElementById('lay_pw').style.display = 'block',
                                document.getElementById('password').select(),
                                document.getElementById('lay_gender').style.display = 'none';
                            break;
                        // ..
                        case 'questionError':
                            break;
                        // admins password appear
                        case 'passwh':
                            window.alert('این حساب کاربری ثبت نام شده و از ادمین ها می باشد');
                            document.getElementById('lay_pw').style.display = 'block', document.getElementById('password').select(), document.getElementById('lay_hide').style.display = 'block', document.getElementById('lay_gender').style.display = 'none';
                            break;
                        // wrong pass
                        case 'pass':
                            window.alert('رمز عبور اشتباه می باشد');
                            break;
                        // i guess it's for Captcha
                        default:
                            try {
                                var t = jQuery.parseJSON(e);
                                'object' == typeof t ? ($('#lay_pw').slideUp(1e3), $('#lay_captcha').slideUp(1e3), $('#lay_gender').slideUp(1e3), $('#lay_hide').slideUp(1e3), $('#lay_security_question').slideDown(1e3)) : null
                            } catch (n) { }
                    }
                    $('#ajax_loader').html('')
                }
            }),
            !1
        )
}
            ";

            public const string LoginJS_member = @"
function login(e) {
    var t = e.username.value;
    return ($('#ajax_loader').html('<center><img height=\'30\' width=\'30\' src=\'/theme/microblog/images/ajax-loader.gif\'></center>'),
            $.ajax({
                type: 'POST',
                url: url('ajax/login/multi'),
                data: $('#form').serialize(),
                success: function (e) {
                    switch (e) {
                        /* case 'captcha':$.msgAlert({text: 'شما ربات تشخیص داده شدید لطفا کد تصویر امنیتی را وارد کنید'});document.getElementById('lay_captcha').style.display = 'block';break;*/

                        // admins
                        case 'admins':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url($chat_prefix);
                            break;
                        // admins mobile - not important
                        case 'adminsmob':
                            alert('درجه دار گرامی توجه کنید : رمز شما ضعیف و نا امن است پسورد خود را پس از ورود به چت روم از تنظمیات تغییر دهید تا این پیام براتون ارسال نشود. پسورد شما باید حداقل 7 کارکتر و شامل حروف و اعداد و حداقل یکی از کاراکتر های ( &,#,$ , % , @ )  باشد . درصورت عدم گذاشتن رمز قوی مسئولیت مشکلات بعدی به عهده شما می باشد . با تشکر');
                            top.location.href = url('mobile');
                            break;
                        // mobile - not important
                        case 'mobile':
                            top.location.href = url('mobile');
                            break;
                        // Joined
                        case 'ok':
                            top.location.href = url($chat_prefix);
                            break;
                        // BlackListed name
                        case 'badname':
                            window.alert('این نام مناسب نمی باشد');
                            break;
                        // Banned
                        case 'benn':
                            window.alert('به دلیل اخراج شدن شما اجازه ی ورود ندارید');
                            break;
                        // Capacity
                        case 'capacity':
                            window.alert('ظرفیت چت روم پر می باشد');
                            break;
                        // Member Loging : Step 2 
                        case 'running':
                            document.getElementById('lay_pw').style.display = 'block',
                                document.getElementById('password').select(),
                                document.getElementById('lay_gender').style.display = 'none';
                            break;
                        // ..
                        case 'questionError':
                            break;
                        // admins password appear
                        case 'passwh':
                            document.getElementById('lay_pw').style.display = 'block', document.getElementById('password').select(), document.getElementById('lay_hide').style.display = 'block', document.getElementById('lay_gender').style.display = 'none';
                            break;
                        // wrong pass
                        case 'pass':
                            window.alert('رمز عبور اشتباه می باشد');
                            break;
                        // i guess it's for Captcha
                        default:
                            try {
                                var t = jQuery.parseJSON(e);
                                'object' == typeof t ? ($('#lay_pw').slideUp(1e3), $('#lay_captcha').slideUp(1e3), $('#lay_gender').slideUp(1e3), $('#lay_hide').slideUp(1e3), $('#lay_security_question').slideDown(1e3)) : null
                            } catch (n) { }
                    }
                    $('#ajax_loader').html('')
                }
            }),
            !1
        )
}
            ";
        }

    }
}
