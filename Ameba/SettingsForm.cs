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
            
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.IsMusicOn = false;
                label3.Text = "Off";
            }
            else if (SettingsClass.IsMusicOn != true)
            {
                SettingsClass.PlayButtonMusic();
                SettingsClass.IsMusicOn = true;
                label3.Text = "On";
            }

        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            if (SettingsClass.IsMusicOn == true)
            {
                SettingsClass.PlayButtonMusic();
            }
            this.Hide();
            homeScreen.Show();
        }
    }
}
