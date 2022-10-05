namespace Projekt_Zaliczeniowy_2020
{
    partial class GameMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayButton = new SpaceUIControls.SimpleButton();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RankingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HomeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControlSpaceBox = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PictureSpaceBox = new System.Windows.Forms.PictureBox();
            this.XLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControlPanel1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlPanel2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpaceBox)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Controls.Add(this.ProfilePicture);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.RankingButton);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(76, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 643);
            this.panel1.TabIndex = 4;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayButton.ChangeBackColor = System.Drawing.Color.Black;
            this.PlayButton.ChangeForeColor = System.Drawing.Color.White;
            this.PlayButton.ControlBackColor = System.Drawing.Color.Black;
            this.PlayButton.ControlFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayButton.ControlForeColor = System.Drawing.Color.White;
            this.PlayButton.InputText = "PLAY!";
            this.PlayButton.Location = new System.Drawing.Point(19, 530);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(165, 43);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Visible = false;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.test_profile_photo;
            this.ProfilePicture.Image = global::Projekt_Zaliczeniowy_2020.Properties.Resources.test_profile_photo;
            this.ProfilePicture.Location = new System.Drawing.Point(19, 52);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(165, 107);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 5;
            this.ProfilePicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NameLabel.Location = new System.Drawing.Point(68, 174);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 25);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Activecolor = System.Drawing.Color.Black;
            this.SettingsButton.BackColor = System.Drawing.Color.Black;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "  Settings";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DisabledColor = System.Drawing.Color.Black;
            this.SettingsButton.Iconcolor = System.Drawing.Color.Black;
            this.SettingsButton.Iconimage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.PinClipart_com_zahnrad_clipart_497960;
            this.SettingsButton.Iconimage_right = null;
            this.SettingsButton.Iconimage_right_Selected = null;
            this.SettingsButton.Iconimage_Selected = null;
            this.SettingsButton.IconMarginLeft = 0;
            this.SettingsButton.IconMarginRight = 0;
            this.SettingsButton.IconRightVisible = true;
            this.SettingsButton.IconRightZoom = 0D;
            this.SettingsButton.IconVisible = true;
            this.SettingsButton.IconZoom = 30D;
            this.SettingsButton.IsTab = false;
            this.SettingsButton.Location = new System.Drawing.Point(9, 348);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.Black;
            this.SettingsButton.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(186, 37);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "  Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RankingButton
            // 
            this.RankingButton.Activecolor = System.Drawing.Color.Black;
            this.RankingButton.BackColor = System.Drawing.Color.Black;
            this.RankingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RankingButton.BorderRadius = 0;
            this.RankingButton.ButtonText = "  Ranking";
            this.RankingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RankingButton.DisabledColor = System.Drawing.Color.Black;
            this.RankingButton.Iconcolor = System.Drawing.Color.Black;
            this.RankingButton.Iconimage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.trophy_32;
            this.RankingButton.Iconimage_right = null;
            this.RankingButton.Iconimage_right_Selected = null;
            this.RankingButton.Iconimage_Selected = null;
            this.RankingButton.IconMarginLeft = 0;
            this.RankingButton.IconMarginRight = 0;
            this.RankingButton.IconRightVisible = true;
            this.RankingButton.IconRightZoom = 0D;
            this.RankingButton.IconVisible = true;
            this.RankingButton.IconZoom = 30D;
            this.RankingButton.IsTab = false;
            this.RankingButton.Location = new System.Drawing.Point(9, 303);
            this.RankingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RankingButton.Name = "RankingButton";
            this.RankingButton.Normalcolor = System.Drawing.Color.Black;
            this.RankingButton.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.RankingButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RankingButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RankingButton.selected = false;
            this.RankingButton.Size = new System.Drawing.Size(186, 37);
            this.RankingButton.TabIndex = 2;
            this.RankingButton.Text = "  Ranking";
            this.RankingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RankingButton.Textcolor = System.Drawing.Color.White;
            this.RankingButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankingButton.Click += new System.EventHandler(this.RankingButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SidePanel.Location = new System.Drawing.Point(6, 258);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(4, 28);
            this.SidePanel.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Activecolor = System.Drawing.Color.Black;
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.BorderRadius = 0;
            this.HomeButton.ButtonText = "  Home";
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.DisabledColor = System.Drawing.Color.Black;
            this.HomeButton.Iconcolor = System.Drawing.Color.Black;
            this.HomeButton.Iconimage = global::Projekt_Zaliczeniowy_2020.Properties.Resources._589_5898244_white_house_logo_png;
            this.HomeButton.Iconimage_right = null;
            this.HomeButton.Iconimage_right_Selected = null;
            this.HomeButton.Iconimage_Selected = null;
            this.HomeButton.IconMarginLeft = 0;
            this.HomeButton.IconMarginRight = 0;
            this.HomeButton.IconRightVisible = true;
            this.HomeButton.IconRightZoom = 0D;
            this.HomeButton.IconVisible = true;
            this.HomeButton.IconZoom = 30D;
            this.HomeButton.IsTab = false;
            this.HomeButton.Location = new System.Drawing.Point(9, 256);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Normalcolor = System.Drawing.Color.Black;
            this.HomeButton.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.HomeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeButton.selected = false;
            this.HomeButton.Size = new System.Drawing.Size(186, 37);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "  Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Textcolor = System.Drawing.Color.White;
            this.HomeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 25;
            this.FormElipse.TargetControl = this;
            // 
            // DragControlSpaceBox
            // 
            this.DragControlSpaceBox.Fixed = true;
            this.DragControlSpaceBox.Horizontal = true;
            this.DragControlSpaceBox.TargetControl = this.PictureSpaceBox;
            this.DragControlSpaceBox.Vertical = true;
            // 
            // PictureSpaceBox
            // 
            this.PictureSpaceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureSpaceBox.Image = global::Projekt_Zaliczeniowy_2020.Properties.Resources._98_987988_spaceship_wallpaper_hd;
            this.PictureSpaceBox.Location = new System.Drawing.Point(0, 0);
            this.PictureSpaceBox.Name = "PictureSpaceBox";
            this.PictureSpaceBox.Size = new System.Drawing.Size(1094, 643);
            this.PictureSpaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSpaceBox.TabIndex = 0;
            this.PictureSpaceBox.TabStop = false;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.Color.Black;
            this.XLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XLabel.ForeColor = System.Drawing.Color.White;
            this.XLabel.Location = new System.Drawing.Point(1061, 10);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(20, 20);
            this.XLabel.TabIndex = 5;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.XLabel_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Controls.Add(this.GameProgressBar);
            this.GamePanel.Location = new System.Drawing.Point(289, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(792, 619);
            this.GamePanel.TabIndex = 0;
            // 
            // GameProgressBar
            // 
            this.GameProgressBar.BackColor = System.Drawing.Color.White;
            this.GameProgressBar.BorderRadius = 7;
            this.GameProgressBar.Location = new System.Drawing.Point(102, 293);
            this.GameProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameProgressBar.MaximumValue = 100;
            this.GameProgressBar.Name = "GameProgressBar";
            this.GameProgressBar.ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.GameProgressBar.Size = new System.Drawing.Size(615, 20);
            this.GameProgressBar.TabIndex = 0;
            this.GameProgressBar.Value = 0;
            this.GameProgressBar.Visible = false;
            // 
            // PanelElipse
            // 
            this.PanelElipse.ElipseRadius = 20;
            this.PanelElipse.TargetControl = this.GamePanel;
            // 
            // DragControlPanel1
            // 
            this.DragControlPanel1.Fixed = true;
            this.DragControlPanel1.Horizontal = true;
            this.DragControlPanel1.TargetControl = this.panel1;
            this.DragControlPanel1.Vertical = true;
            // 
            // DragControlPanel2
            // 
            this.DragControlPanel2.Fixed = true;
            this.DragControlPanel2.Horizontal = true;
            this.DragControlPanel2.TargetControl = this.panel2;
            this.DragControlPanel2.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.panel;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 643);
            this.panel2.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DataAccessLayer.User);
            // 
            // GameMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1094, 643);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureSpaceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpaceBox)).EndInit();
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureSpaceBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton HomeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel NameLabel;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton RankingButton;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControlSpaceBox;
        private Bunifu.Framework.UI.BunifuCustomLabel XLabel;
        private SpaceUIControls.SimpleButton PlayButton;
        private System.Windows.Forms.Panel GamePanel;
        private Bunifu.Framework.UI.BunifuElipse PanelElipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControlPanel1;
        private Bunifu.Framework.UI.BunifuDragControl DragControlPanel2;
        private Bunifu.Framework.UI.BunifuProgressBar GameProgressBar;
    }
}