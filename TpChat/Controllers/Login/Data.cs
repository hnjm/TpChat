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
        public static bool FirstSubmit = true;

        public const string URL = "http://www.persiann24.tk/";
        public struct ID
        {
            public const string USERNAME = "username";
            public const string PASSWORD = "password";
            public const string GENDER = "gender";
            public const string BUTTON = "submit_button";
            // there is also this feature -hide- for admins:
            // <input name="hide" value="1" type="checkbox">
        }
    }
}
