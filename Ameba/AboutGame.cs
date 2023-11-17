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
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            SettingsClass.PlayButtonMusic();
            this.Hide();
            homeScreen.Show();
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
    }
}
