using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SpaceUIControls
{
    [DefaultEvent("Click")]
    public partial class AnimatedButton : UserControl
    {
        int wh = 20;
        float ang = 45;
        string text = "Button";
        Color firstColor = Color.Black;
        Color secondColor = Color.Gray;
        Timer t = new Timer();
        public int BorderRadius 
        { 
            get 
            { 
                return wh; 
            }
            set
            {
                wh = value;
                Invalidate();
            }
        }
        public Color Color1 
        {
            get
            {
                return firstColor;
            }
            set
            {
                firstColor = value;
            }
        }
        public Color Color2
        {
            get
            {
                return secondColor;
            }
            set
            {
                secondColor = value;
            }
        }
        public float Ang
        {
            get
            {
                return ang;
            }
            set
            {
                ang = value;
                Invalidate();
            }

        }
        public AnimatedButton()
        {
            InitializeComponent();
            DoubleBuffered = true;
            t.Interval = 10;
            t.Start();
            t.Tick += (s, e) => { Ang = Ang % 360 + 1; };
        }
        public string TextButton
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height-wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height-wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, firstColor, secondColor, ang), gp);
            e.Graphics.DrawString(TextButton, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }
    }
}
