using SpaceUIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_2020
{
    public static class Validation
    {
        public static bool ControlValidation(Panel panel)
        {
            var controls = panel.Controls;
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is SimpleTextControl)
                {
                    if ((controls[i] as SimpleTextControl).InputText == "")
                    {
                        (controls[i] as SimpleTextControl).ErrorVisible = true;
                        (controls[i] as SimpleTextControl).ErrorMsg = "This field is required!";
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool ValidEmailAddress(SimpleControl emailAddress)
        {

            // Confirm that the email address string is not empty.
            if (emailAddress.InputText.Length == 0)
            {
                emailAddress.ErrorVisible = true;
                emailAddress.ErrorMsg = "Email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.InputText.IndexOf("@") > -1)
            {
                if (emailAddress.InputText.IndexOf(".", emailAddress.InputText.IndexOf("@")) > emailAddress.InputText.IndexOf("@"))
                {

                    return true;
                }
            }
            else
            {
                emailAddress.ErrorVisible = true;
                emailAddress.ErrorMsg = "Email address must be valid email address format.";
            }
            return false;
        }
        public static bool ValidLength(SimpleControl control, int leng)
        {
            if (control.InputText.Length < leng)
            {
                control.ErrorVisible = true;
                return false;
            }
            return true;
        }
       
    }
}
