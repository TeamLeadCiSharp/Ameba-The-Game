using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    internal class ScoreClass: GameForm
    {
        public static int score = 0;
        public void GetScore(ref Label ScoreLabel, ref Label HealthLabel)
        {
            ScoreLabel.Text = "Score: " + score.ToString();
            HealthLabel.Text = "Health: " + AmebaClass.Health.ToString();
        }
        public static void ResetScore()
        {
            score = 0;
            AmebaClass.Health = 100;
        }

    }
}
