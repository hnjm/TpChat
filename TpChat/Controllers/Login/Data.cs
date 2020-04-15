using System;

namespace TpChat.Controllers.Login
{
    /* IMPORTANT
     * Handling alerts:
     * use console.log() instead and capture the message
     * by ConsoleMessage event of geckofx.
    */
    /* Considerale Events:
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
        //public Cookie;
        public static bool Joined = false;

        public static string URL = "http://www.persiann24.tk/";
        public static string DOMAIN = "www.persiann24.tk";
        //public static string URL_banned { get { return URL + "benned"; } }

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
        // TODO:
        // alerts for other events.
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
