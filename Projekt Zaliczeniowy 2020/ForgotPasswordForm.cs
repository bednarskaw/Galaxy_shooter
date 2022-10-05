using DataAccessLayer;
using SpaceUIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.ServiceModel;
using Projekt_Zaliczeniowy_2020.EmailServiceAPI;


namespace Projekt_Zaliczeniowy_2020
{
    public partial class ForgotPasswordForm : Form
    {
        GameDB gamebase;
        private IMenuHandler menuHandler;
        public ForgotPasswordForm(IMenuHandler handler)
        {
            InitializeComponent();
            SendButton.ButtonClick += new EventHandler(SendButton_Click);
            menuHandler = handler;
        }

        private void XLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void SendButton_Click(object sender, EventArgs e)
        {
            //TO EXECUTE THIS CODE YOU MUST ENABLE https://www.google.com/settings/security/lesssecureapps

            gamebase = new GameDB();
            if (gamebase.Database.Exists())
            {
                if (Validation.ValidEmailAddress(EmailTextBox))
                {
                    var user = gamebase.Users.Where(u => u.Email.Equals(EmailTextBox.InputText)).ToList();
                    if (user.Count == 1)
                    {
                        if (user[0].Email == EmailTextBox.InputText)
                        {
                            string password = Membership.GeneratePassword(12, 1);
                            EmailServiceClient emailClient = new EmailServiceClient();
                            try
                            {
                                MessageLabel.Visible = true;
                                bool send = emailClient.SendEmail(EmailTextBox.InputText, password, user[0].Login);
                                if (send)
                                {
                                    EmailTextBox.InputText = "";
                                    MessageLabel.Text = "Message has been sent!";
                                    user[0].Password = password;
                                    gamebase.SaveChanges();
                                }
                                else
                                {
                                    EmailTextBox.InputText = "";
                                    MessageLabel.Text = "Please try again..";
                                   
                                }
                            }
                            catch (FaultException exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                            finally
                            {
                                emailClient.Close();
                            }
                        }
                            //this.Close();
                            
                        }
                    }
                }

            }
        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuHandler.DisableMenu(false);
        }

       
    }
}
