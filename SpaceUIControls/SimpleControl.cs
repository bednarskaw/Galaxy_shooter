using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceUIControls
{
    public partial class SimpleControl: UserControl
    {
        public SimpleControl()
        {
            InitializeComponent();
        }
        public char PasswordChar
        {
            get
            {
                return InputTextBox.PasswordChar;
            }
            set
            {
                InputTextBox.PasswordChar = value;
            }
        }
        public string InputText
        {
            get
            {
                return InputTextBox.Text;
            }
            set
            {
                InputTextBox.Text = value;
                //OnShowOrHideErrorBox(InputTextBox.Text);
            }
        }
        public Font FontInput
        {
            get
            {
                return InputTextBox.Font;
            }
            set
            {
                InputTextBox.Font = value;
                //OnShowOrHideErrorBox(InputTextBox.Text);
            }
        }
        
        bool autoShowError;
     
        public string ErrorMsg
        {
            get
            {
                return ErrorLabel.Text;
            }
            set
            {
                ErrorLabel.Text = value;
                OnShowOrHideErrorBox(ErrorLabel.Text);
            }
        }
        public void Clear()
        {
            InputTextBox.Clear();
        }

        protected virtual void OnShowOrHideErrorBox(string text)
        {
            if (autoShowError)
            {
                if (text != null && text.Length > 0)
                {
                    ErrorLabel.Visible = true;
                }
                else
                {
                    ErrorLabel.Visible = false;
                }
            }
            else
            {
                ErrorLabel.Visible = ErrorVisible;
            }
        }

        public bool ErrorVisible
        {
            get
            {
                return ErrorLabel.Visible;
            }
            set
            {
                ErrorLabel.Visible = value;

            }
        }
        
        public bool AutoShowError
        {
            get
            {
                return autoShowError;
                
            }
            set
            {
                autoShowError = true;
                OnShowOrHideErrorBox(ErrorLabel.Text);
            }
        }

        private void ErrorLabel_VisibleChanged(object sender, EventArgs e)
        {
            if (ErrorLabel.Visible)
            {
                this.Height = InputTextBox.Height + this.Padding.Top + this.Padding.Bottom + ErrorLabel.Height+10;
            }
            else
            {
                this.Height = InputTextBox.Height + this.Padding.Top + this.Padding.Bottom+10;
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorVisible = false;
        }
    }
}
