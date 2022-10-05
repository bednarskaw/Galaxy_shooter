namespace Projekt_Zaliczeniowy_2020
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UnderPicturePanel = new System.Windows.Forms.Panel();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PictureDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SpacePicture = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new SpaceUIControls.SimpleButton();
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainBlackPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShootingStarTimer = new System.Windows.Forms.Timer(this.components);
            this.PasswordTextBox = new SpaceUIControls.SimplePictureControl();
            this.LoginTextBox = new SpaceUIControls.SimplePictureControl();
            ((System.ComponentModel.ISupportInitialize)(this.SpacePicture)).BeginInit();
            this.MainBlackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UnderPicturePanel
            // 
            this.UnderPicturePanel.BackColor = System.Drawing.Color.White;
            this.UnderPicturePanel.ForeColor = System.Drawing.Color.White;
            this.UnderPicturePanel.Location = new System.Drawing.Point(0, 284);
            this.UnderPicturePanel.Name = "UnderPicturePanel";
            this.UnderPicturePanel.Size = new System.Drawing.Size(343, 3);
            this.UnderPicturePanel.TabIndex = 6;
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccountLabel.ForeColor = System.Drawing.Color.White;
            this.CreateAccountLabel.Location = new System.Drawing.Point(104, 552);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(132, 20);
            this.CreateAccountLabel.TabIndex = 8;
            this.CreateAccountLabel.Text = "Create account";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Black;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(150, 585);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(39, 20);
            this.ExitLabel.TabIndex = 12;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PictureDragControl
            // 
            this.PictureDragControl.Fixed = true;
            this.PictureDragControl.Horizontal = true;
            this.PictureDragControl.TargetControl = this.SpacePicture;
            this.PictureDragControl.Vertical = true;
            // 
            // SpacePicture
            // 
            this.SpacePicture.Image = global::Projekt_Zaliczeniowy_2020.Properties.Resources.Smallspacerlogin;
            this.SpacePicture.Location = new System.Drawing.Point(0, 0);
            this.SpacePicture.Name = "SpacePicture";
            this.SpacePicture.Size = new System.Drawing.Size(339, 285);
            this.SpacePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpacePicture.TabIndex = 0;
            this.SpacePicture.TabStop = false;
            this.SpacePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.SpacePicture_Paint);
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(170, 455);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(144, 20);
            this.ForgotPasswordLabel.TabIndex = 7;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPassword_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogInButton.ChangeBackColor = System.Drawing.Color.White;
            this.LogInButton.ChangeForeColor = System.Drawing.Color.Black;
            this.LogInButton.ControlBackColor = System.Drawing.Color.White;
            this.LogInButton.ControlFont = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.ControlForeColor = System.Drawing.Color.Black;
            this.LogInButton.InputText = "LOG IN";
            this.LogInButton.Location = new System.Drawing.Point(31, 491);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(286, 43);
            this.LogInButton.TabIndex = 16;
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // MainBlackPanel
            // 
            this.MainBlackPanel.Controls.Add(this.pictureBox1);
            this.MainBlackPanel.Controls.Add(this.SpacePicture);
            this.MainBlackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBlackPanel.Location = new System.Drawing.Point(0, 0);
            this.MainBlackPanel.Name = "MainBlackPanel";
            this.MainBlackPanel.Size = new System.Drawing.Size(341, 614);
            this.MainBlackPanel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Projekt_Zaliczeniowy_2020.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(338, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ShootingStarTimer
            // 
            this.ShootingStarTimer.Enabled = true;
            this.ShootingStarTimer.Interval = 10;
            this.ShootingStarTimer.Tick += new System.EventHandler(this.ShootingStarTimer_Tick);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoShowError = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.PasswordTextBox.ControlImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.pngkey_com_lock_icon_png_2343797;
            this.PasswordTextBox.ErrorMsg = "Incorrect password!";
            this.PasswordTextBox.ErrorVisible = false;
            this.PasswordTextBox.InputText = "";
            this.PasswordTextBox.Location = new System.Drawing.Point(28, 391);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(286, 41);
            this.PasswordTextBox.TabIndex = 15;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.AutoShowError = true;
            this.LoginTextBox.BackColor = System.Drawing.Color.Black;
            this.LoginTextBox.ControlImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources._496_4968268_appliance_repair_clipart;
            this.LoginTextBox.ErrorMsg = "Incorrect login!";
            this.LoginTextBox.ErrorVisible = false;
            this.LoginTextBox.InputText = "";
            this.LoginTextBox.Location = new System.Drawing.Point(31, 324);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.Size = new System.Drawing.Size(283, 41);
            this.LoginTextBox.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(341, 614);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.UnderPicturePanel);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.MainBlackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SpacePicture)).EndInit();
            this.MainBlackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel UnderPicturePanel;
        private System.Windows.Forms.PictureBox SpacePicture;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.Label ExitLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl PictureDragControl;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private SpaceUIControls.SimplePictureControl LoginTextBox;
        private SpaceUIControls.SimplePictureControl PasswordTextBox;
        private SpaceUIControls.SimpleButton LogInButton;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private System.Windows.Forms.Panel MainBlackPanel;
        private System.Windows.Forms.Timer ShootingStarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

