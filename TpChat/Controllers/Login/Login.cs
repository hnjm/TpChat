using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpChat.Controllers.Login;


namespace TpChat.Views
{
    partial class Login : Form
    {
        public void CheckLogStatus(Gecko.GeckoDocument document)
        {
            //Data.Joined;
        }
        public void FirstSubmit()
        {
            var document = browser.Document;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                        .Value = txtboxUsername.Text;

            (document.GetElementById(Data.ID.GENDER) as Gecko.DOM.GeckoSelectElement)
                .SelectedIndex = this.cmbxGender.SelectedIndex;

            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();

            this.firstSubmit = false;
            this.Phase2();
        }
        public void SecondSubmit()
        {
            var document = browser.Document;

            (document.GetElementById(Data.ID.PASSWORD) as Gecko.DOM.GeckoInputElement)
                        .Value = this.txtboxPassword.Text;

            (document.GetElementById(Data.ID.USERNAME) as Gecko.DOM.GeckoInputElement)
                .Value = txtboxUsername.Text;

            (document.GetElementById(Data.ID.BUTTON) as Gecko.DOM.GeckoInputElement)
                .Click();
        }
    }
}
