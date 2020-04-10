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
    }
}
