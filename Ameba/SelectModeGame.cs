using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    public partial class SelectModeGame : Form
    {
        public SelectModeGame()
        {
            InitializeComponent();
        }

        private void EasyLabel_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsClass.PlayButtonMusic();
            GameForm gameForm = new GameForm();
            ScoreClass.ResetScore();
            GameState.IsLevelEasy = true;
            GameState.IsLevelMedium = false;
            GameState.IsLevelHard = false;
            GameState.IsGameOver = false;
            GameState.SetPositionForVirus = false;
            gameForm.Timer.Enabled = true;
            gameForm.Timer.Start();
            gameForm.UpdateTimer.Enabled = true;
            gameForm.UpdateTimer.Start();   
            gameForm.Show();
        }
        private void MediumLabel_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsClass.PlayButtonMusic();
            GameForm gameForm = new GameForm();
            ScoreClass.ResetScore();
            GameState.IsLevelEasy = false;
            GameState.IsLevelMedium = true;
            GameState.IsLevelHard = false;
            GameState.IsGameOver = false;
            GameState.SetPositionForVirus = false;
            gameForm.Timer.Enabled = true;
            gameForm.Timer.Start();
            gameForm.UpdateTimer.Enabled = true;
            gameForm.UpdateTimer.Start(); ;
            gameForm.Show();
        }
        private void HardLabel_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsClass.PlayButtonMusic();
            GameForm gameForm = new GameForm();
            ScoreClass.ResetScore();
            GameState.IsLevelEasy = false;
            GameState.IsLevelMedium = false;
            GameState.IsLevelHard = true;
            GameState.IsGameOver = false;
            GameState.SetPositionForVirus = false;
            gameForm.Timer.Enabled = true;
            gameForm.Timer.Start();
            gameForm.UpdateTimer.Enabled = true;
            gameForm.UpdateTimer.Start();
            gameForm.Show();
        }
        private void EasyLabel_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = EasyLabel.Location;
            EasyLabel.Font = new Font(EasyLabel.Font.FontFamily, 18, FontStyle.Bold);
            EasyLabel.Location = new Point(oldLocation.X - 5, oldLocation.Y + 0);
        }

        private void EasyLabel_MouseLeave(object sender, EventArgs e)
        {
            Point oldLocation = EasyLabel.Location;
            EasyLabel.Font = new Font(EasyLabel.Font.FontFamily, 16, FontStyle.Bold);
            EasyLabel.Location = new Point(oldLocation.X + 5, oldLocation.Y + 0);
        }

        private void MediumLabel_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = MediumLabel.Location;
            MediumLabel.Font = new Font(MediumLabel.Font.FontFamily, 18, FontStyle.Bold);
            MediumLabel.Location = new Point(oldLocation.X - 5, oldLocation.Y + 0);
        }

        private void MediumLabel_MouseLeave(object sender, EventArgs e)
        {
            Point oldLocation = MediumLabel.Location;
            MediumLabel.Font = new Font(MediumLabel.Font.FontFamily, 16, FontStyle.Bold);
            MediumLabel.Location = new Point(oldLocation.X + 5, oldLocation.Y + 0);
        }

        private void HardLabel_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = HardLabel.Location;
            HardLabel.Font = new Font(HardLabel.Font.FontFamily, 18, FontStyle.Bold);
            HardLabel.Location = new Point(oldLocation.X - 5, oldLocation.Y + 0);
        }

        private void HardLabel_MouseLeave(object sender, EventArgs e)
        {
            Point oldLocation = HardLabel.Location;
            HardLabel.Font = new Font(HardLabel.Font.FontFamily, 16, FontStyle.Bold);
            HardLabel.Location = new Point(oldLocation.X + 5, oldLocation.Y - 0);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = pictureBox1.Location;
            Size oldSize = pictureBox1.Size;

            pictureBox1.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            pictureBox1.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            SettingsClass.PlayButtonMusic();
            homeScreen.Show();
            Close();
        }
    }
}
