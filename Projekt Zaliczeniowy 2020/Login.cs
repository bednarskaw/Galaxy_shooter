using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_2020
{
    public partial class Login : Form, IMenuHandler
    {
        GameDB gamebase;
        float[] starsX;
        float[] starsY;
        float[] starsSpeed;
        Random rand;
        
        public Login()
        {
            InitializeComponent();
            starsX = new float[] {  160, 250, 60, 10, -50, 100, 15, 300 };
            starsY = new float[] { -60, -50, -40, -50, -70, -130, -30, -100 };
            starsSpeed = new float[] { 0.5f, 3f, 0.8f, 0.3f, 1f, 2f, 0.5f, 0.4f };
            rand = new Random();
            LogInButton.ButtonClick+= new EventHandler(LogInButton_Click);
            gamebase = new GameDB();
            this.TransparencyKey = Color.LightSteelBlue;
            var bmp = new Bitmap(Projekt_Zaliczeniowy_2020.Properties.Resources.PasswordBackground);

           // pi.Image = new Bitmap(imgStream);
            Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm(this);
            DisableMenu(true);
            form.MdiParent = this;
            form.Show();
            form.Location = new Point(30, 70);
        }
        public void DisableMenu(bool isForgotPassword) 
        {
            if (isForgotPassword)
            {
                ShootingStarTimer.Stop();
                SpacePicture.Visible = false;
                LoginTextBox.Visible = false;
                PasswordTextBox.Visible = false;
                LogInButton.Visible = false;
                MainBlackPanel.Visible = false;
                UnderPicturePanel.Visible = false;
                ExitLabel.Location = new Point(150, 465);
                ForgotPasswordLabel.Visible = false;
                CreateAccountLabel.Visible = false;
            }
            else
            {
                ShootingStarTimer.Start();
                SpacePicture.Visible = true;
                LoginTextBox.Visible = true;
                PasswordTextBox.Visible = true;
                LogInButton.Visible = true;
                MainBlackPanel.Visible = true;
                UnderPicturePanel.Visible = true;
                ExitLabel.Location = new Point(150, 585);
                ForgotPasswordLabel.Visible = true;
                CreateAccountLabel.Visible = true;
            }
        }
        
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            new CreateAccount().Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (gamebase.Database.Exists())
            {
                var login = gamebase.Users.Where(u => u.Login.Equals(LoginTextBox.InputText)).ToList();
                if (login.Count == 1)
                {
                    if (login[0].Password == PasswordTextBox.InputText)
                    {
                        this.Hide();
                        GameMenu gm = new GameMenu(login[0], gamebase);
                        gm.Closed += (s, args) => this.Close();
                        gm.Show();
                        ShootingStarTimer.Stop();
                    }
                    else
                    {
                        PasswordTextBox.ErrorVisible = true;
                    }
                }
                else
                {
                    LoginTextBox.ErrorVisible = true;
                }
            }
            else
            {
                User user = new User() { Login="admin", Password="admin1234", Email= "spacegameshoot@gmail.com"};
                gamebase.Users.Add(user);
                gamebase.SaveChanges();
            }
       
        }
   
        private void ShootingStarTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                starsY[i] += starsSpeed[i];
                starsX[i] += starsSpeed[i];
            }
            
            this.Refresh();

        }
        
        private void SpacePicture_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(pictureBox1.Image, starsX[0], starsY[0], 25, 25);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[1], starsY[1], 35, 35);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[2], starsY[2], 15, 15);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[3], starsY[3], 30, 30);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[4], starsY[4], 20, 20);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[5], starsY[5], 10, 10);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[6], starsY[6], 10, 10);
            e.Graphics.DrawImage(pictureBox1.Image, starsX[7], starsY[7], 10, 10);
            for (int i = 0; i < 8; i++)
            {

                if (starsX[i] > SpacePicture.Width)
                {

                    starsY[i] = rand.Next(-200, -60);
                    starsX[i] = rand.Next(-100, SpacePicture.Width);
                }
                if (starsY[i] > SpacePicture.Height)
                {

                    starsY[i] = rand.Next(-200, -60);
                    starsX[i] = rand.Next(-100, SpacePicture.Width);
                }
            }

        }

  
    }
}
