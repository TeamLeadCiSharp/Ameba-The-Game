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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void NextLang_Click(object sender, EventArgs e)
        {
            SettingsClass.PlayButtonMusic();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            SettingsClass.PlayButtonMusic();
            this.Hide();
            homeScreen.Show();
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
    }
}
