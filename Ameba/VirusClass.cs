﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    public class VirusClass: GameForm
    {
        private int speed = 50;
        public static (int, int) GetPositionOfViruses(ref PictureBox obj)
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
            
            void BehaviourOfVirus1(ref PictureBox Virus1, ref PictureBox Virus2, ref PictureBox Virus3, int diifVNX, int diffVNY)
            {
                if (diifVNX > 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus1, ref Virus2, ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus1, virus2: ref Virus2, virus3: ref Virus3);
                        break;
                    }
                }
            }
            void BehaviourOfVirus2(ref PictureBox Virus2, ref PictureBox Virus1, ref PictureBox Virus3, int diifVNX, int diffVNY)
            {
                if (diifVNX > 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus2, virus2: ref Virus1, virus3: ref Virus3);
                        break;
                    }
                }
            }

            void BehaviourOfVirus3(ref PictureBox Virus3, ref PictureBox Virus2, ref PictureBox Virus1, int diifVNX, int diffVNY)
            {
                if (diifVNX > 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY > 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < diffVNY; i++)
                    {
                        MoveDown(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY == 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX < 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < Math.Abs(diifVNX); i++)
                    {
                        MoveLeft(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX == 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
                else if (diifVNX > 0 && diffVNY < 0)
                {
                    Timer.Interval = Math.Abs(diifVNX) * 2000;
                    for (int i = 0; i < diifVNX; i++)
                    {
                        MoveRight(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                    Timer.Interval = Math.Abs(diffVNY);
                    for (int i = 0; i < Math.Abs(diffVNY); i++)
                    {
                        MoveUp(virus1: ref Virus3, virus2: ref Virus1, virus3: ref Virus2);
                        break;
                    }
                }
            }

            if (GameState.IsLevelEasy == true && GameState.IsLevelMedium == false && GameState.IsLevelHard == false)
            {
                BehaviourOfVirus1(Virus1: ref Virus1, ref Virus2, ref Virus3, diff1X, diff1Y);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == true && GameState.IsLevelHard == false)
            {
                BehaviourOfVirus1(Virus1: ref Virus1, ref Virus2, ref Virus3, diff1X, diff1Y);
                BehaviourOfVirus2(Virus2: ref Virus2, ref Virus1, ref Virus3, diff2X, diff2Y);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == false && GameState.IsLevelHard == true)
            {
                BehaviourOfVirus1(Virus1: ref Virus1, ref Virus2, ref Virus3, diff1X, diff1Y);
                BehaviourOfVirus2(Virus2: ref Virus2, ref Virus1, ref Virus3, diff2X, diff2Y);
                BehaviourOfVirus3(Virus3: ref Virus3, ref Virus2, ref Virus1, diff3X, diff3Y);
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
                Virus3.Top = 100;
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == true && GameState.IsLevelHard == false)
            {
                Virus1.Left = 50;
                Virus1.Top = 50;

                Virus2.Left = 250;
                Virus2.Top = 50;

                Virus3.Hide();
                Virus3.Left = 550;
                Virus3.Top = 100;
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
        public void MoveLeft(ref PictureBox virus1, ref PictureBox virus2, ref PictureBox virus3)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus1.Left > 0)
                {
                    if (!virus1.Bounds.IntersectsWith(virus2.Bounds) || !virus1.Bounds.IntersectsWith(virus3.Bounds))
                    {
                        if (virus1.Left + 50 != virus2.Left || virus1.Left + 50 != virus3.Left)
                        {
                            virus1.Left -= speed;
                        }
                        
                    }

                }
            }

        }

        public void MoveRight(ref PictureBox virus1, ref PictureBox virus2, ref PictureBox virus3)
        {

            if (GameState.IsGameOver == false)
            {
                if (virus1.Right < 450)
                {
                    if (!virus1.Bounds.IntersectsWith(virus2.Bounds) || !virus1.Bounds.IntersectsWith(virus3.Bounds))
                    {
                        if (virus1.Left + 50 != virus2.Left || virus1.Left + 50 != virus3.Left)
                        {
                            virus1.Left += speed;
                        }

                    }
                }
            }

        }

        public void MoveUp(ref PictureBox virus1, ref PictureBox virus2, ref PictureBox virus3)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus1.Top != 0)
                {
                    if (!virus1.Bounds.IntersectsWith(virus2.Bounds) || !virus1.Bounds.IntersectsWith(virus3.Bounds))
                    {
                        if (virus1.Left + 50 != virus2.Left || virus1.Left + 50 != virus3.Left)
                        {
                            virus1.Top -= speed;
                        }

                    }
                }
            }

        }

        public void MoveDown(ref PictureBox virus1, ref PictureBox virus2, ref PictureBox virus3)
        {
            if (GameState.IsGameOver == false)
            {
                if (virus1.Bottom < 450)
                {
                    if (!virus1.Bounds.IntersectsWith(virus2.Bounds) || !virus1.Bounds.IntersectsWith(virus3.Bounds))
                    {
                        if (virus1.Left + 50 != virus2.Left || virus1.Left + 50 != virus3.Left)
                        {
                            virus1.Top += speed;
                        }

                    }

                }
            }

        }
    }
}
