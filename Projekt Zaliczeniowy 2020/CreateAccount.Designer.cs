namespace Projekt_Zaliczeniowy_2020
{
    partial class CreateAccount
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
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new SpaceUIControls.SimpleTextControl();
            this.SurnameTextBox = new SpaceUIControls.SimpleTextControl();
            this.EmailTextBox = new SpaceUIControls.SimpleTextControl();
            this.LoginTextBox = new SpaceUIControls.SimpleTextControl();
            this.PasswordTextBox = new SpaceUIControls.SimpleTextControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SubmitButton = new SpaceUIControls.SimpleButton();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.XLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateAccountLabel.Location = new System.Drawing.Point(63, 27);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(208, 34);
            this.CreateAccountLabel.TabIndex = 1;
            this.CreateAccountLabel.Text = "Create Account";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoShowError = true;
            this.NameTextBox.BackColor = System.Drawing.Color.Black;
            this.NameTextBox.ErrorMsg = "This field is incorrect!";
            this.NameTextBox.ErrorVisible = false;
            this.NameTextBox.InputText = "";
            this.NameTextBox.LabelTextBox = "Name";
            this.NameTextBox.Location = new System.Drawing.Point(3, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.Size = new System.Drawing.Size(397, 56);
            this.NameTextBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.AutoShowError = true;
            this.SurnameTextBox.BackColor = System.Drawing.Color.Black;
            this.SurnameTextBox.ErrorMsg = "This field is incorrect!";
            this.SurnameTextBox.ErrorVisible = false;
            this.SurnameTextBox.InputText = "";
            this.SurnameTextBox.LabelTextBox = "Surname";
            this.SurnameTextBox.Location = new System.Drawing.Point(3, 65);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.PasswordChar = '\0';
            this.SurnameTextBox.Size = new System.Drawing.Size(397, 56);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AutoShowError = true;
            this.EmailTextBox.BackColor = System.Drawing.Color.Black;
            this.EmailTextBox.ErrorMsg = "This field is incorrect!";
            this.EmailTextBox.ErrorVisible = false;
            this.EmailTextBox.InputText = "";
            this.EmailTextBox.LabelTextBox = "Email";
            this.EmailTextBox.Location = new System.Drawing.Point(3, 251);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.Size = new System.Drawing.Size(397, 56);
            this.EmailTextBox.TabIndex = 4;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.AutoShowError = true;
            this.LoginTextBox.BackColor = System.Drawing.Color.Black;
            this.LoginTextBox.ErrorMsg = "This field is incorrect!";
            this.LoginTextBox.ErrorVisible = false;
            this.LoginTextBox.InputText = "";
            this.LoginTextBox.LabelTextBox = "Login";
            this.LoginTextBox.Location = new System.Drawing.Point(3, 127);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.Size = new System.Drawing.Size(369, 56);
            this.LoginTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoShowError = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.PasswordTextBox.ErrorMsg = "This field is incorrect!";
            this.PasswordTextBox.ErrorVisible = false;
            this.PasswordTextBox.InputText = "";
            this.PasswordTextBox.LabelTextBox = "Password";
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 189);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.Size = new System.Drawing.Size(397, 56);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.SurnameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LoginTextBox);
            this.flowLayoutPanel1.Controls.Add(this.PasswordTextBox);
            this.flowLayoutPanel1.Controls.Add(this.EmailTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 334);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.ChangeBackColor = System.Drawing.Color.White;
            this.SubmitButton.ChangeForeColor = System.Drawing.Color.Black;
            this.SubmitButton.ControlBackColor = System.Drawing.Color.White;
            this.SubmitButton.ControlFont = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.ControlForeColor = System.Drawing.Color.Black;
            this.SubmitButton.InputText = "SUBMIT";
            this.SubmitButton.Location = new System.Drawing.Point(29, 484);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(286, 43);
            this.SubmitButton.TabIndex = 7;
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnLabel.ForeColor = System.Drawing.Color.White;
            this.ReturnLabel.Location = new System.Drawing.Point(133, 544);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(64, 20);
            this.ReturnLabel.TabIndex = 8;
            this.ReturnLabel.Text = "Return";
            this.ReturnLabel.Click += new System.EventHandler(this.ReturnLabel_Click);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.Color.Black;
            this.XLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XLabel.ForeColor = System.Drawing.Color.White;
            this.XLabel.Location = new System.Drawing.Point(318, 5);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(20, 20);
            this.XLabel.TabIndex = 9;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.XLabel_Click);
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 25;
            this.FormElipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(341, 614);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.ReturnLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreateAccountLabel;
        private SpaceUIControls.SimpleTextControl NameTextBox;
        private SpaceUIControls.SimpleTextControl SurnameTextBox;
        private SpaceUIControls.SimpleTextControl EmailTextBox;
        private SpaceUIControls.SimpleTextControl LoginTextBox;
        private SpaceUIControls.SimpleTextControl PasswordTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SpaceUIControls.SimpleButton SubmitButton;
        private System.Windows.Forms.Label ReturnLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel XLabel;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}