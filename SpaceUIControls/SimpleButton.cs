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
    public partial class SimpleButton : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;
        public string InputText
        {
            get
            {
                return Button.Text;
            }
            set
            {
                Button.Text = value;
            }
        }
        private Color changeBackColor;
        private Color changeForeColor;
        public Color ChangeBackColor
        {
            get
            {
                return changeBackColor;
            }
            set
            {
                changeBackColor = value;
            }
        }
        public Color ChangeForeColor
        {
            get
            {
                return changeForeColor;
            }
            set
            {
                changeForeColor = value;
            }
        }
        public Color ControlBackColor
        {
            get
            {
                return Button.BackColor;
            }
            set
            {
                Button.BackColor = value;
            }
        }
        public Color ControlForeColor
        {
            get
            {
                return Button.ForeColor;
            }
            set
            {
                Button.ForeColor = value;
            }
        }
        public Font ControlFont
        {
            get
            {
                return Button.Font;
            }
            set
            {
                Button.Font = value;
            }
        }

        public SimpleButton()
        {
            InitializeComponent();
            Button.MouseEnter += OnMouseEnterButton1;
            Button.MouseLeave += OnMouseLeaveButton1;
        }
        //public static SimpleButton operator+(SimpleButton simpleButton, EventHandler e)
        //{
        //    simpleButton.Button.Click += e;
        //    return simpleButton;
        //}
        
      
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            ControlBackColor = changeForeColor;
            ControlForeColor = changeBackColor;


        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            ControlBackColor = changeBackColor;
            ControlForeColor = changeForeColor;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                ButtonClick?.Invoke(this, e);
        }
    }
}
