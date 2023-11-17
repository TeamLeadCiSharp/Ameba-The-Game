using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ameba
{
    public class SettingsClass
    {
        public static bool IsMusicOn = true;
        public static bool LangUa = false;
        public static void PlayButtonMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\bazar\\OneDrive\\Desktop\\Ameba — копия — копия — копия\\Music\\click.wav";
            player.Play();
        }
        public static void PlayLoseMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\bazar\\OneDrive\\Desktop\\Ameba — копия — копия — копия\\Music\\level-failed.wav";
            player.Play();
        }
    }
}
