namespace Projekt_Zaliczeniowy_2020
{
    partial class Ranking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RankingPositionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.RankingDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ElipseRanking = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RankingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPanel.Controls.Add(this.BestScoreLabel);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.RankingPositionLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.CreateAccountLabel);
            this.MainPanel.Controls.Add(this.RankingDataGrid);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(791, 616);
            this.MainPanel.TabIndex = 0;
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.AutoSize = true;
            this.BestScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.BestScoreLabel.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BestScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BestScoreLabel.Location = new System.Drawing.Point(232, 132);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(42, 48);
            this.BestScoreLabel.TabIndex = 6;
            this.BestScoreLabel.Text = "0";
            this.BestScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(141, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best Score:";
            // 
            // RankingPositionLabel
            // 
            this.RankingPositionLabel.AutoSize = true;
            this.RankingPositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.RankingPositionLabel.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RankingPositionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RankingPositionLabel.Location = new System.Drawing.Point(232, 352);
            this.RankingPositionLabel.Name = "RankingPositionLabel";
            this.RankingPositionLabel.Size = new System.Drawing.Size(42, 48);
            this.RankingPositionLabel.TabIndex = 4;
            this.RankingPositionLabel.Text = "0";
            this.RankingPositionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ranking Position:";
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateAccountLabel.Location = new System.Drawing.Point(517, 42);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(200, 34);
            this.CreateAccountLabel.TabIndex = 2;
            this.CreateAccountLabel.Text = "Users Ranking";
            // 
            // RankingDataGrid
            // 
            this.RankingDataGrid.AllowUserToAddRows = false;
            this.RankingDataGrid.AllowUserToDeleteRows = false;
            this.RankingDataGrid.AllowUserToResizeColumns = false;
            this.RankingDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RankingDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RankingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RankingDataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.RankingDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RankingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RankingDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RankingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RankingDataGrid.ColumnHeadersHeight = 50;
            this.RankingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RankingDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RankingDataGrid.DoubleBuffered = true;
            this.RankingDataGrid.EnableHeadersVisualStyles = false;
            this.RankingDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RankingDataGrid.HeaderBgColor = System.Drawing.Color.Black;
            this.RankingDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.RankingDataGrid.Location = new System.Drawing.Point(482, 91);
            this.RankingDataGrid.Name = "RankingDataGrid";
            this.RankingDataGrid.ReadOnly = true;
            this.RankingDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RankingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RankingDataGrid.RowHeadersVisible = false;
            this.RankingDataGrid.RowHeadersWidth = 62;
            this.RankingDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RankingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RankingDataGrid.RowTemplate.Height = 28;
            this.RankingDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RankingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RankingDataGrid.Size = new System.Drawing.Size(260, 441);
            this.RankingDataGrid.TabIndex = 0;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(DataAccessLayer.Game);
            // 
            // ElipseRanking
            // 
            this.ElipseRanking.ElipseRadius = 20;
            this.ElipseRanking.TargetControl = this.RankingDataGrid;
            // 
            // ElipseForm
            // 
            this.ElipseForm.ElipseRadius = 20;
            this.ElipseForm.TargetControl = this;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Zaliczeniowy_2020.Properties.Resources.spaceshipCopy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 616);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RankingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid RankingDataGrid;
        private Bunifu.Framework.UI.BunifuElipse ElipseRanking;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.Label RankingPositionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BestScoreLabel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse ElipseForm;
    }
}