namespace Projekt_Zaliczeniowy_2020
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.EmailTextBox = new SpaceUIControls.SimpleTextControl();
            this.PasswordTextBox = new SpaceUIControls.SimpleTextControl();
            this.NameTextBox = new SpaceUIControls.SimpleTextControl();
            this.SurnameTextBox = new SpaceUIControls.SimpleTextControl();
            this.UploadButton = new SpaceUIControls.SimpleButton();
            this.ApplyButton = new SpaceUIControls.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsLabel.Location = new System.Drawing.Point(300, 35);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(185, 53);
            this.SettingsLabel.TabIndex = 2;
            this.SettingsLabel.Text = "Settings";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicture.Image = global::Projekt_Zaliczeniowy_2020.Properties.Resources.test_profile_photo;
            this.ProfilePicture.Location = new System.Drawing.Point(467, 207);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(266, 188);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 8;
            this.ProfilePicture.TabStop = false;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.EmailTextBox);
            this.DataPanel.Controls.Add(this.PasswordTextBox);
            this.DataPanel.Controls.Add(this.NameTextBox);
            this.DataPanel.Controls.Add(this.SurnameTextBox);
            this.DataPanel.Location = new System.Drawing.Point(70, 92);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(308, 408);
            this.DataPanel.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AutoShowError = true;
            this.EmailTextBox.BackColor = System.Drawing.Color.Black;
            this.EmailTextBox.BackColorLabel = System.Drawing.Color.Black;
            this.EmailTextBox.ErrorMsg = "Error";
            this.EmailTextBox.ErrorVisible = false;
            this.EmailTextBox.FontInput = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.FontLabel = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColorLabel = System.Drawing.Color.White;
            this.EmailTextBox.InputText = "";
            this.EmailTextBox.LabelTextBox = "Email";
            this.EmailTextBox.Location = new System.Drawing.Point(24, 220);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.Size = new System.Drawing.Size(259, 41);
            this.EmailTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoShowError = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BackColorLabel = System.Drawing.Color.Black;
            this.PasswordTextBox.ErrorMsg = "Error";
            this.PasswordTextBox.ErrorVisible = false;
            this.PasswordTextBox.FontInput = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.FontLabel = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.ForeColorLabel = System.Drawing.Color.White;
            this.PasswordTextBox.InputText = "";
            this.PasswordTextBox.LabelTextBox = "Password";
            this.PasswordTextBox.Location = new System.Drawing.Point(24, 306);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(259, 45);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoShowError = true;
            this.NameTextBox.BackColor = System.Drawing.Color.Black;
            this.NameTextBox.BackColorLabel = System.Drawing.Color.Black;
            this.NameTextBox.ErrorMsg = "Error";
            this.NameTextBox.ErrorVisible = false;
            this.NameTextBox.FontInput = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.FontLabel = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColorLabel = System.Drawing.Color.White;
            this.NameTextBox.InputText = "";
            this.NameTextBox.LabelTextBox = "Name";
            this.NameTextBox.Location = new System.Drawing.Point(24, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.Size = new System.Drawing.Size(259, 45);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.AutoShowError = true;
            this.SurnameTextBox.BackColor = System.Drawing.Color.Black;
            this.SurnameTextBox.BackColorLabel = System.Drawing.Color.Black;
            this.SurnameTextBox.ErrorMsg = "Error";
            this.SurnameTextBox.ErrorVisible = false;
            this.SurnameTextBox.FontInput = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.FontLabel = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.ForeColorLabel = System.Drawing.Color.White;
            this.SurnameTextBox.InputText = "";
            this.SurnameTextBox.LabelTextBox = "Surname";
            this.SurnameTextBox.Location = new System.Drawing.Point(24, 130);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.PasswordChar = '\0';
            this.SurnameTextBox.Size = new System.Drawing.Size(259, 45);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadButton.ChangeBackColor = System.Drawing.Color.White;
            this.UploadButton.ChangeForeColor = System.Drawing.Color.Black;
            this.UploadButton.ControlBackColor = System.Drawing.Color.White;
            this.UploadButton.ControlFont = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UploadButton.ControlForeColor = System.Drawing.Color.Black;
            this.UploadButton.InputText = "Upload";
            this.UploadButton.Location = new System.Drawing.Point(619, 408);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(114, 36);
            this.UploadButton.TabIndex = 10;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyButton.ChangeBackColor = System.Drawing.Color.Black;
            this.ApplyButton.ChangeForeColor = System.Drawing.Color.White;
            this.ApplyButton.ControlBackColor = System.Drawing.Color.Black;
            this.ApplyButton.ControlFont = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplyButton.ControlForeColor = System.Drawing.Color.White;
            this.ApplyButton.InputText = "APPLY!";
            this.ApplyButton.Location = new System.Drawing.Point(239, 517);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(344, 62);
            this.ApplyButton.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 616);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private SpaceUIControls.SimpleTextControl SurnameTextBox;
        private SpaceUIControls.SimpleTextControl NameTextBox;
        private SpaceUIControls.SimpleTextControl PasswordTextBox;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private SpaceUIControls.SimpleButton ApplyButton;
        private SpaceUIControls.SimpleButton UploadButton;
        private System.Windows.Forms.Panel DataPanel;
        private SpaceUIControls.SimpleTextControl EmailTextBox;
    }
}