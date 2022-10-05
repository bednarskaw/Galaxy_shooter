using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Projekt_Zaliczeniowy_2020
{
    public partial class GameMenu : Form
    {
        GameDB gamebase;
        User user;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        Convertion c = new Convertion();

        Process proc;
        private IntPtr hWndOriginalParent;
        private IntPtr hWndDocked;
        List<Form> menuForms;
        private bool isPlayed;
        Func<byte[], Image> convertion;
       

        public GameMenu(User userFromLogin, GameDB gb)
        {
            user = userFromLogin;
            gamebase = gb;
            InitializeComponent();

            PlayButton.ButtonClick+= new EventHandler(PlayButton_Click);

            menuForms = new List<Form>();
            
            CreateNewForms();
         
            convertion = c.ConvertBinaryToImage;


            isPlayed = false;
            Page_Load(menuForms[0]);
            NameLabel.Text = user.Login;
        }
        private void CreateNewForms()
        {
            Home home = new Home(user, gamebase) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Ranking ranking = new Ranking(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Settings settings = new Settings(gamebase, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home.StartGame += new Home.Play(StartGame);

            menuForms.Add(home);
            menuForms.Add(ranking);
            menuForms.Add(settings);
        }
        private void Page_Load(Form form)
        {
       
            //this.GamePanel.Controls.Clear();
            
            foreach (Form f in menuForms)
            {
                if(form==f && !isPlayed)
                {
                    this.GamePanel.Controls.Add(f);
                    f.Show();
                }
                else
                {
                    f.Hide();
                }
            }
        }
        private void CloseAllForms()
        {
            foreach (Form f in menuForms)
            {
                f.Close();
            }
            menuForms.Clear();
        }
        private void GameMenu_Load(object sender, EventArgs e)
        {
            Page_Load(menuForms[0]);
            NameLabel.Text = user.Login;

            if (user.ImageFile != null)
            {
                ProfilePicture.Image = convertion(user.ImageFile);
            }
            MoveSidePanel(HomeButton);
            try
            {
                string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                path += "\\PCGame_Build\\PCGame_Build_Data\\Score.txt";
                File.WriteAllText(path, String.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void XLabel_Click(object sender, EventArgs e)
        {
            StopPlaying();
            this.Close();
        }
        private void MoveSidePanel(Control control)
        {
            SidePanel.Height = control.Height;
            SidePanel.Top = control.Top;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            PlayButton.Visible = false;
            if (isPlayed)
            {
                StopPlaying();
            }
            MoveSidePanel(HomeButton);
            Page_Load(menuForms[0]);
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            PlayButton.Visible = true;
            if (isPlayed)
            {
                StopPlaying();
            }
            MoveSidePanel(RankingButton);
            Page_Load(menuForms[1]);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            PlayButton.Visible = true;
            if (isPlayed)
            {
                StopPlaying();
            }
            MoveSidePanel(SettingsButton);
            Page_Load(menuForms[2]);
        }
        private void Panel_Resize(object sender, EventArgs e)
        {
            MoveWindow(hWndDocked, 0, 0, GamePanel.Width, GamePanel.Height, true);
        }
        private void StopPlaying()
        {
           
            if (proc != null && isPlayed)
            {
                if (gamebase.Database.Exists())
                {
                    isPlayed = false;
                    string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    path += "\\PCGame_Build\\PCGame_Build_Data\\Score.txt";
                    string[] lines = System.IO.File.ReadAllLines(path);
                    DateTime myDateTime = DateTime.Now;
                    foreach (string line in lines)
                    {
                        Game userGame = new Game
                        {
                            Date = myDateTime,
                            Score = Convert.ToInt32(line),
                            User = user,
                            User_UserId = user.UserId
                        };
                        gamebase.Games.Add(userGame);
                        if (user.Games == null)
                        {
                            user.Games = new List<Game>();

                        }
                        user.Games.Add(userGame);
                        gamebase.SaveChanges();
                    }
                }
                proc.Kill();
                proc.WaitForExit();
                proc.Dispose();
                proc.Close();
                hWndDocked = IntPtr.Zero;
                GameProgressBar.Visible = false;
                CreateNewForms();
            }

        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private async void StartGame()
        {
                CloseAllForms();
                GameProgressBar.Visible = true;
                Cursor.Current = Cursors.WaitCursor;
                isPlayed = true;
                if (hWndDocked != IntPtr.Zero) 
                    return;
                IntPtr hWndParent = IntPtr.Zero;
                string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                wanted_path += "\\PCGame_Build\\PCGame_Build.exe";
                proc = new Process();
                proc.StartInfo.CreateNoWindow = false;
            proc = Process.Start(wanted_path);

            while (hWndDocked == IntPtr.Zero)
                {
                    proc.WaitForInputIdle(1000);
                    proc.Refresh();              
                    if (proc.HasExited)
                    {
                        return; 
                    }
                    hWndDocked = proc.MainWindowHandle;  
                }

                MoveWindow(hWndDocked, GamePanel.Width, GamePanel.Height, 0, 0, true);
                hWndOriginalParent = SetParent(hWndDocked, GamePanel.Handle);
                GamePanel.SizeChanged += new EventHandler(Panel_Resize);

                GameProgressBar.Value = 0;
                var progress = new Progress<int>(percent =>
                {
                    GameProgressBar.Value = percent;

                });
                await Task.Run(() => Wait(progress));
                hWndOriginalParent = SetParent(hWndDocked, GamePanel.Handle);
                GamePanel.SizeChanged += new EventHandler(Panel_Resize);
                Panel_Resize(new Object(), new EventArgs());
                Cursor.Current = Cursors.Default;
        }
 
        public void Wait(IProgress<int> progress)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(30);
                if (progress != null)
                    progress.Report(i);
            }
            
        }


  
    }
}
