using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpChat.Controllers.Login
{
    public static class Data
    {
        const string URL = "http://www.persiann24.tk/";
        struct ID
        {
            const string USERNAME = "username";
            const string PASSWORD = "password";
            const string GENDER = "gender";
            const string BUTTON = "submit_button";
            // there is also this feature -hide- for admins:
            // <input name="hide" value="1" type="checkbox">
        }
    }
}
