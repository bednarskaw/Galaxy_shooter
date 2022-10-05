using DataAccessLayer;
using SpaceUIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_2020
{
    public partial class Settings : Form
    {
        private readonly GameDB gamebase;
        private readonly User user;
        
        Func<byte[], Image> byteConvertion;
        Func<Image, byte[]> imageConvertion;

        public Settings(GameDB b, User u)
        {
        
            InitializeComponent();
            UploadButton.ButtonClick += new EventHandler(UploadImage);
            ApplyButton.ButtonClick += new EventHandler(SaveChanges);
            gamebase = b;
            user = u;
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {
            Convertion convertion = new Convertion();
            NameTextBox.InputText = user.Name;
            SurnameTextBox.InputText = user.Surname;
            EmailTextBox.InputText = user.Email;
            PasswordTextBox.InputText = user.Password;
            byteConvertion = convertion.ConvertBinaryToImage;
            imageConvertion = convertion.ConvertImageToBinary;

            if (user.ImageFile != null)
            {
                ProfilePicture.Image = byteConvertion(user.ImageFile);
            }
            
        }


        private void UploadImage(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg",  Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ProfilePicture.Image = Image.FromFile(ofd.FileName);
                }
            }
            
        }
        private async void SaveChanges(object sender, EventArgs e)
        {
            
            
                if (Validation.ControlValidation(DataPanel) && Validation.ValidLength(PasswordTextBox, 7) && Validation.ValidEmailAddress(EmailTextBox))
                {
                    user.Name = NameTextBox.InputText;
                    user.Surname = SurnameTextBox.InputText;
                    user.Email = EmailTextBox.InputText;
                    user.Password = PasswordTextBox.InputText;
                    user.ImageFile = imageConvertion(ProfilePicture.Image);
                    await gamebase.SaveChangesAsync();
                }
            
        }

      
    }
}
