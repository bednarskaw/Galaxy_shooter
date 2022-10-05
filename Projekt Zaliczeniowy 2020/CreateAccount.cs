using DataAccessLayer;
using SpaceUIControls;
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
    public partial class CreateAccount : Form
    {
        GameDB gamebase;
        public CreateAccount()
        {
            InitializeComponent();
            SubmitButton.ButtonClick += new EventHandler(SubmitButton_Click);
            gamebase = new GameDB();

        }

        private void XLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
           
            if((Validation.ControlValidation(flowLayoutPanel1) && Validation.ValidLength(LoginTextBox, 3) && Validation.ValidLength(PasswordTextBox, 7) && Validation.ValidEmailAddress(EmailTextBox)))
            {
                var login = gamebase.Users.Where(u => u.Login.Equals(LoginTextBox.InputText)).ToList();
                if (login.Count == 0)
                {
                    User newUser = new User
                    {
                        Login = LoginTextBox.InputText,
                        Password = PasswordTextBox.InputText,
                        Email = EmailTextBox.InputText,
                        Name = NameTextBox.InputText,
                        Surname = SurnameTextBox.InputText
                    };
                    gamebase.Users.Add(newUser);
                    gamebase.SaveChanges();
                    this.Close();
                }
                
            }
         
        }
    }

}
