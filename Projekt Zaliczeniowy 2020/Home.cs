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
    public partial class Home : Form
    {
        User user;
        GameDB gamebase;
      
        public delegate void Play();
        public event Play StartGame;
        public Home(User u, GameDB g)
        {
            gamebase = g;
            user = u;  
            InitializeComponent();

            if (gamebase.Database.Exists())
            {
             
                {
                    MainPanel.BackColor = Color.FromArgb(125, Color.Black);
                    BigNameLabel.Text = user.Login;

                    var lastGameDate = gamebase.Database.SqlQuery<DateTime>("with tmp as (SELECT Max(GameId) as LastGameId FROM Games WHERE User_UserId=" + user.UserId + ") SELECT Date FROM Games join tmp on Games.GameId=tmp.LastGameId");
                    if (lastGameDate.ToList().Count > 0)
                    {
                        ShowDateLabel.Text = lastGameDate.ToList()[0].ToString("dd.MM.yyyy");
                        var lastScore = gamebase.Database.SqlQuery<int>("with tmp as (SELECT Max(GameId) as LastGameId FROM Games WHERE User_UserId =" + user.UserId + ") SELECT Score FROM Games join tmp on Games.GameId = tmp.LastGameId");
                        ShowScoreLabel.Text = lastScore.ToList()[0].ToString();
                    }
                }
                
            }

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

    }
}
