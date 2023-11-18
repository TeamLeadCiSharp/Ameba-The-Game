using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    internal class VirusClass: GameForm
    {
        private int speed = 50;
        private (int, int) GetPositionOfViruses(ref PictureBox obj)
        {
            return (obj.Left, obj.Top);
        }
        public void FindAmebaAlgoritm(ref PictureBox Ameba, ref PictureBox Virus1, ref PictureBox Virus2, ref PictureBox Virus3)
        {
            var amebaCoordinates = GetPositionOfViruses(ref Ameba);
            var virusCoordinates = GetPositionOfViruses(ref Virus1);
            var virus2Coordinates = GetPositionOfViruses(ref Virus2);
            var virus3Coordinates = GetPositionOfViruses(ref Virus3);

            int amebaX = amebaCoordinates.Item1;
            int amebaY = amebaCoordinates.Item2;

            int virus1X = virusCoordinates.Item1;
            int virus1Y = virusCoordinates.Item2;

            int virus2X = virus2Coordinates.Item1;
            int virus2Y = virus2Coordinates.Item2;

            int virus3X = virus3Coordinates.Item1;
            int virus3Y = virus3Coordinates.Item2;

            int diff1X = (amebaX - virus1X) / 50;
            int diff1Y = (amebaY - virus1Y) / 50;

            int diff2X = (amebaX - virus2X) / 50;
            int diff2Y = (amebaY - virus2Y) / 50;

            int diff3X = (amebaX - virus3X) / 50;
            int diff3Y = (amebaY - virus3Y) / 50;
            
            void BehaviourOfVirus(ref PictureBox Virus, int diifVNX, int diffVNY)
            {
                if (diifVNX > 0 && diffVNY > 0)
                {
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(Virus);
                        Timer.Interval = 2000;
                    }
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX == 0 && diffVNY > 0)
                {
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX < 0 && diffVNY > 0)
                {
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(Virus);
                        Timer.Interval = 2000;
                    }
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX > 0 && diffVNY == 0)
                {
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX < 0 && diffVNY == 0)
                {
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX < 0 && diffVNY < 0)
                {
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(Virus);
                        Timer.Interval = 2000;
                    }
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX == 0 && diffVNY < 0)
                {
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(Virus);
                        Timer.Interval = 2000;
                    }
                }
                else if (diifVNX > 0 && diffVNY < 0)
                {
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(Virus);
                        Timer.Interval = 2000;
                    }
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(Virus);
                        Timer.Interval = 2000;
                    }
                }
            }

            if (GameState.IsLevelEasy == true && GameState.IsLevelMedium == false && GameState.IsLevelHard == false)
            {
                BehaviourOfVirus(ref Virus1, diff1X, diff1Y);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == true && GameState.IsLevelHard == false)
            {
                BehaviourOfVirus(ref Virus1, diff1X, diff1Y);
                BehaviourOfVirus(ref Virus2, diff2X, diff2Y);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == false && GameState.IsLevelHard == true)
            {
                BehaviourOfVirus(ref Virus1, diff1X, diff1Y);
                BehaviourOfVirus(ref Virus2, diff2X, diff2Y);
                BehaviourOfVirus(ref Virus3, diff3X, diff3Y);
            }
        }
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
