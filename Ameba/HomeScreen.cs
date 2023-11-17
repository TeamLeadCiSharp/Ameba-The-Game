using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Ameba
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            Close();
        }

        private void StartBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectModeGame selectModeGame = new SelectModeGame();
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            selectModeGame.Show();
        }

        private void StartBox_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = StartBox.Location;
            Size oldSize = StartBox.Size;

            StartBox.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            StartBox.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void StartBox_MouseLeave(object sender, EventArgs e)
        {
            StartBox.Size = new Size(StartBox.Size.Width - 10, StartBox.Size.Height - 10);
            StartBox.Location = new Point(StartBox.Location.X + 5, StartBox.Location.Y + 5);
        }



        private void InfoBox_Click(object sender, EventArgs e)
        {
            AboutGame aboutGame = new AboutGame();
            this.Hide();
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            aboutGame.Show();
        }

        private void InfoBox_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = InfoBox.Location;
            Size oldSize = InfoBox.Size;

            InfoBox.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            InfoBox.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void InfoBox_MouseLeave(object sender, EventArgs e)
        {
            InfoBox.Size = new Size(InfoBox.Size.Width - 10, InfoBox.Size.Height - 10);
            InfoBox.Location = new Point(InfoBox.Location.X + 5, InfoBox.Location.Y + 5);
        }

        private void SettingsBox_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = SettingsBox.Location;
            Size oldSize = SettingsBox.Size;

            SettingsBox.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            SettingsBox.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void SettingsBox_MouseLeave(object sender, EventArgs e)
        {
            SettingsBox.Size = new Size(SettingsBox.Size.Width - 10, SettingsBox.Size.Height - 10);
            SettingsBox.Location = new Point(SettingsBox.Location.X + 5, SettingsBox.Location.Y + 5);
        }

        private void ExitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Point oldLocation = ExitPictureBox.Location;
            Size oldSize = ExitPictureBox.Size;

            ExitPictureBox.Size = new Size(oldSize.Width + 10, oldSize.Height + 10);
            ExitPictureBox.Location = new Point(oldLocation.X - 5, oldLocation.Y - 5);
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.Size = new Size(ExitPictureBox.Size.Width - 10, ExitPictureBox.Size.Height - 10);
            ExitPictureBox.Location = new Point(ExitPictureBox.Location.X + 5, ExitPictureBox.Location.Y + 5);
        }

        private void SettingsBox_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            this.Hide();
            settingsForm.Show();
        }
    }
}
