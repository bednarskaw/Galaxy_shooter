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
    public partial class SimplePictureControl : SimpleControl
    {
        public SimplePictureControl()
        {
            InitializeComponent();
        }

        public Image ControlImage
        {
            get
            {
                return ImagePictureBox.Image;
            }
            set
            {
                ImagePictureBox.Image = value;
            }
        }
    }
}
