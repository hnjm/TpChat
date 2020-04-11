using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpChat.Controllers.Login
{
    public static class Data
    {
        //public Cookie;
        public static bool Joined = false;

        public const string URL = "http://www.persiann24.tk/";
        public const string URL_banned = "http://www.persiann24.tk/benned";

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
        public const string LoginFun_guest = @"
function login(e) { // e = this = Window
    1 == firstlogin && ($('#password').val(''), firstlogin = !1);
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
            ";
        public const string LoginFun_member = @"
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
            ";
    }
}
