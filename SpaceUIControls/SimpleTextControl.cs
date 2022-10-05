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
    public partial class SimpleTextControl : SimpleControl
    {
        public SimpleTextControl()
        {
            InitializeComponent();
        }
        public string LabelTextBox
        {
            get
            {
                return TextLabel.Text;
            }
            set
            {
                TextLabel.Text = value;
            }
        }
        public Font FontLabel
        {
            get
            {
                return TextLabel.Font;
            }
            set
            {
                TextLabel.Font = value;
                
            }
        }
        public Color BackColorLabel
        {
            get
            {
                return TextLabel.BackColor;
            }
            set
            {
                TextLabel.BackColor = value;

            }
        }
        public Color ForeColorLabel
        {
            get
            {
                return TextLabel.ForeColor;
            }
            set
            {
                TextLabel.ForeColor = value;

            }
        }
    }
}
