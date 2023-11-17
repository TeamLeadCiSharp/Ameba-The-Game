using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void ResultTimer_Tick(object sender, EventArgs e)
        {
            
            FinalFormLabel.Text = "Your score: " + ScoreClass.score + "!"; 
        }

        private void GoHome_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = GoHome.Location;
            Size oldSize = GoHome.Size;

            GoHome.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            GoHome.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void GoHome_MouseLeave(object sender, EventArgs e)
        {
            GoHome.Size = new Size(GoHome.Size.Width - 10, GoHome.Size.Height - 10);
            GoHome.Location = new Point(GoHome.Location.X + 5, GoHome.Location.Y + 5);
        }

        

        private void GoHome_MouseEnter_1(object sender, EventArgs e)
        {
            Point oldLocation = GoHome.Location;
            Size oldSize = GoHome.Size;

            GoHome.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            GoHome.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void GoHome_MouseLeave_1(object sender, EventArgs e)
        {
            GoHome.Size = new Size(GoHome.Size.Width - 10, GoHome.Size.Height - 10);
            GoHome.Location = new Point(GoHome.Location.X + 5, GoHome.Location.Y + 5);
        }

        private void GoHome_Click_1(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            GameState.IsGameOver = false;
            GameState.SetPositionForVirus = false;
            Hide();
            homeScreen.Show();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayLoseMusic();
            }
        }
    }
}
