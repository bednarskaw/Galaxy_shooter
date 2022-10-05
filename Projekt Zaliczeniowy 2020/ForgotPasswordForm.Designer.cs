namespace Projekt_Zaliczeniowy_2020
{
    partial class ForgotPasswordForm
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
            this.components = new System.ComponentModel.Container();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.XLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EmailTextBox = new SpaceUIControls.SimplePictureControl();
            this.ResetPasswordLabel = new System.Windows.Forms.Label();
            this.SendButton = new SpaceUIControls.SimpleButton();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccountLabel.ForeColor = System.Drawing.Color.White;
            this.CreateAccountLabel.Location = new System.Drawing.Point(105, 368);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(64, 20);
            this.CreateAccountLabel.TabIndex = 9;
            this.CreateAccountLabel.Text = "Return";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccountLabel_Click);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.Color.Black;
            this.XLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XLabel.ForeColor = System.Drawing.Color.White;
            this.XLabel.Location = new System.Drawing.Point(250, 5);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(20, 20);
            this.XLabel.TabIndex = 12;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.XLabel_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AutoShowError = true;
            this.EmailTextBox.BackColor = System.Drawing.Color.Black;
            this.EmailTextBox.ControlImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.emailIcon;
            this.EmailTextBox.ErrorMsg = "Incorrect Email!";
            this.EmailTextBox.ErrorVisible = false;
            this.EmailTextBox.FontInput = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.InputText = "";
            this.EmailTextBox.Location = new System.Drawing.Point(23, 154);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.Size = new System.Drawing.Size(234, 41);
            this.EmailTextBox.TabIndex = 10;
            // 
            // ResetPasswordLabel
            // 
            this.ResetPasswordLabel.AutoSize = true;
            this.ResetPasswordLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetPasswordLabel.Location = new System.Drawing.Point(18, 55);
            this.ResetPasswordLabel.Name = "ResetPasswordLabel";
            this.ResetPasswordLabel.Size = new System.Drawing.Size(240, 29);
            this.ResetPasswordLabel.TabIndex = 13;
            this.ResetPasswordLabel.Text = "Reset Your Password";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendButton.ChangeBackColor = System.Drawing.Color.White;
            this.SendButton.ChangeForeColor = System.Drawing.Color.Black;
            this.SendButton.ControlBackColor = System.Drawing.Color.White;
            this.SendButton.ControlFont = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.ControlForeColor = System.Drawing.Color.Black;
            this.SendButton.InputText = "SEND";
            this.SendButton.Location = new System.Drawing.Point(28, 300);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(217, 47);
            this.SendButton.TabIndex = 11;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MessageLabel.Location = new System.Drawing.Point(40, 215);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(205, 20);
            this.MessageLabel.TabIndex = 14;
            this.MessageLabel.Text = "Message has been sent!";
            this.MessageLabel.Visible = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(274, 432);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ResetPasswordLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.CreateAccountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPasswordForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private SpaceUIControls.SimplePictureControl EmailTextBox;
        private System.Windows.Forms.Label CreateAccountLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel XLabel;
        private System.Windows.Forms.Label ResetPasswordLabel;
        private SpaceUIControls.SimpleButton SendButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}