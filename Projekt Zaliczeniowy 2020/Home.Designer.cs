namespace Projekt_Zaliczeniowy_2020
{
    partial class Home
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.PlayButton = new SpaceUIControls.AnimatedButton();
            this.ShowScoreLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ShowDateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ScoreLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RecentlyPlayedGame = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BigNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.WelcomeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPanel.Controls.Add(this.ButtonPanel);
            this.MainPanel.Controls.Add(this.ShowScoreLabel);
            this.MainPanel.Controls.Add(this.ShowDateLabel);
            this.MainPanel.Controls.Add(this.ScoreLabel);
            this.MainPanel.Controls.Add(this.DateLabel);
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.RecentlyPlayedGame);
            this.MainPanel.Controls.Add(this.BigNameLabel);
            this.MainPanel.Controls.Add(this.WelcomeLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(791, 616);
            this.MainPanel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonPanel.Controls.Add(this.PlayButton);
            this.ButtonPanel.Location = new System.Drawing.Point(259, 413);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(250, 129);
            this.ButtonPanel.TabIndex = 17;
            // 
            // PlayButton
            // 
            this.PlayButton.Ang = 162F;
            this.PlayButton.BorderRadius = 20;
            this.PlayButton.Color1 = System.Drawing.Color.Black;
            this.PlayButton.Color2 = System.Drawing.SystemColors.HotTrack;
            this.PlayButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(5, 4);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(240, 120);
            this.PlayButton.TabIndex = 16;
            this.PlayButton.TextButton = "PLAY NOW!";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ShowScoreLabel
            // 
            this.ShowScoreLabel.AutoSize = true;
            this.ShowScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShowScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ShowScoreLabel.Location = new System.Drawing.Point(470, 295);
            this.ShowScoreLabel.Name = "ShowScoreLabel";
            this.ShowScoreLabel.Size = new System.Drawing.Size(69, 25);
            this.ShowScoreLabel.TabIndex = 15;
            this.ShowScoreLabel.Text = "Score";
            this.ShowScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowDateLabel
            // 
            this.ShowDateLabel.AutoSize = true;
            this.ShowDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowDateLabel.ForeColor = System.Drawing.Color.White;
            this.ShowDateLabel.Location = new System.Drawing.Point(271, 296);
            this.ShowDateLabel.Name = "ShowDateLabel";
            this.ShowDateLabel.Size = new System.Drawing.Size(57, 25);
            this.ShowDateLabel.TabIndex = 14;
            this.ShowDateLabel.Text = "Date";
            this.ShowDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ScoreLabel.Location = new System.Drawing.Point(402, 296);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(76, 25);
            this.ScoreLabel.TabIndex = 12;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateLabel.Location = new System.Drawing.Point(216, 296);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(64, 25);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Date:";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(221, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 10;
            // 
            // RecentlyPlayedGame
            // 
            this.RecentlyPlayedGame.AutoSize = true;
            this.RecentlyPlayedGame.BackColor = System.Drawing.Color.Transparent;
            this.RecentlyPlayedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecentlyPlayedGame.ForeColor = System.Drawing.Color.White;
            this.RecentlyPlayedGame.Location = new System.Drawing.Point(262, 252);
            this.RecentlyPlayedGame.Name = "RecentlyPlayedGame";
            this.RecentlyPlayedGame.Size = new System.Drawing.Size(278, 29);
            this.RecentlyPlayedGame.TabIndex = 9;
            this.RecentlyPlayedGame.Text = "Recently played game:";
            this.RecentlyPlayedGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BigNameLabel
            // 
            this.BigNameLabel.AutoSize = true;
            this.BigNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BigNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BigNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BigNameLabel.Location = new System.Drawing.Point(325, 142);
            this.BigNameLabel.Name = "BigNameLabel";
            this.BigNameLabel.Size = new System.Drawing.Size(111, 40);
            this.BigNameLabel.TabIndex = 7;
            this.BigNameLabel.Text = "name";
            this.BigNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(256, 66);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(253, 63);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 20;
            this.FormElipse.TargetControl = this;
            // 
            // PanelElipse
            // 
            this.PanelElipse.ElipseRadius = 20;
            this.PanelElipse.TargetControl = this.ButtonPanel;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.spaceshipCopy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 616);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel ScoreLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel DateLabel;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel RecentlyPlayedGame;
        private Bunifu.Framework.UI.BunifuCustomLabel BigNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel WelcomeLabel;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Bunifu.Framework.UI.BunifuCustomLabel ShowDateLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel ShowScoreLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private SpaceUIControls.AnimatedButton PlayButton;
        private Bunifu.Framework.UI.BunifuElipse PanelElipse;
    }
}