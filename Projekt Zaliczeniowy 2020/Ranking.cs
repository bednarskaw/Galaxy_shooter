using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_2020
{
    public partial class Ranking : Form
    {
        GameDB gamebase;
        User user;
        public Ranking(User u)
        {
            InitializeComponent();
            //this.MainPanel.BackColor = Color.FromArgb(125, Color.Black);
            gamebase = new GameDB();
            user = u;
          
        }
        
        private void Ranking_Load(object sender, EventArgs e)
        {
           
            

            if (gamebase.Database.Exists())
            {
                var conStr= gamebase.Database.Connection.ConnectionString;
                SqlConnection con = new SqlConnection(conStr);
                string query = "Select Login, MAX(Score) as MaxScore, RANK() OVER(ORDER BY MAX(Score) DESC) as Rank from Games inner join Users on Games.User_UserId=Users.UserId GROUP BY Login";
                SqlCommand command = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                RankingDataGrid.DataSource = dt;

                if (gamebase.Games.Count() > 0)
                {
                        var maxScore = gamebase.Database.SqlQuery<int>("Select MAX(Score) as MaxScore from Games where User_UserId=" + user.UserId);
                    
                        BestScoreLabel.Text = maxScore.ToList()[0].ToString();

                        var rankPosition = gamebase.Database.SqlQuery<long>("with tmp as (" + query + ")Select Rank from tmp where Login='" + user.Login + "'");
                        RankingPositionLabel.Text = rankPosition.Cast<long>().ToList()[0].ToString();
                    
                }
                con.Close();
        

            }
        }

       
    }
}
