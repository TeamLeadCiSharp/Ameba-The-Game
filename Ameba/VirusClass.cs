using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    internal class VirusClass: GameForm
    {
        private int speed = 50;
        public void StartPositionForViruses(ref PictureBox Virus1, ref PictureBox Virus2, ref PictureBox Virus3)
        {
            if (GameState.IsLevelEasy == true && GameState.IsLevelMedium == false && GameState.IsLevelHard == false)
            {
                Virus1.Left = 50;
                Virus1.Top = 50;

                Virus2.Hide();
                Virus2.Left = 550;
                Virus2.Top = 50;

                Virus3.Hide();
                Virus3.Left = 550;
                Virus3.Top = 50;
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == true && GameState.IsLevelHard == false)
            {
                Virus1.Left = 50;
                Virus1.Top = 50;

                Virus2.Left = 250;
                Virus2.Top = 50;

                Virus3.Hide();
                Virus3.Left = 550;
                Virus3.Top = 50;
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == false && GameState.IsLevelHard == true)
            {
                Virus1.Left = 50;
                Virus1.Top = 50;

                Virus2.Left = 250;
                Virus2.Top = 50;

                Virus3.Left = 400;
                Virus3.Top = 50;
            }
        }
        public void MoveLeft(PictureBox virus)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus.Left > 0)
                {
                    virus.Left -= speed;
                }
            }

        }

        public void MoveRight(PictureBox virus)
        {

            if (GameState.IsGameOver == false)
            {
                if (virus.Right < 450)
                {
                    virus.Left += speed;
                }
            }

        }

        public void MoveUp(PictureBox virus)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus.Top != 0)
                {
                    virus.Top -= speed;
                }
            }

        }

        public void MoveDown(PictureBox virus)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus.Bottom < 450)
                {
                    virus.Top += speed;
                }
            }

        }
    }
}
