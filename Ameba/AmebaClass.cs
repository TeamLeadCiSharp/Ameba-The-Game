using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    internal class AmebaClass: GameForm, IMovable, IEater
    {
        public PictureBox Ameba { get; }
        public static int Health = 100;
        private bool finalFormShown = false;
        private int speed = 50;
        FinalForm finalForm = new FinalForm();
        public AmebaClass(PictureBox ameba)
        {
            Ameba = ameba;
        }
        public void MoveLeft()
        {
            if (Ameba.Left > 0)
            {
                Ameba.Left -= speed;
            }
        }

        public void MoveRight()
        {
            if (Ameba.Right < 450)
            {
                Ameba.Left += speed;
            }
        }

        public void MoveUp()
        {
            if (Ameba.Top != 0)
            {
                Ameba.Top -= speed;
            }
        }

        public void MoveDown()
        {
            if (Ameba.Bottom < 450)
            {
                Ameba.Top += speed;
            }
        }
        public void EatBurger(ref PictureBox Ameba, ref PictureBox Burger)
        {
            if (Ameba.Bounds.IntersectsWith(Burger.Bounds))
            {
                if (Health == 100)
                {
                    Burger.Hide();
                    Burger.Left = 500;
                    ItemClass.BurgerWasEaten = true;
                    ScoreClass.score += 5;
                    
                }
                else if (Health != 100)
                {
                    Burger.Hide();
                    Health += 10;
                    ItemClass.BurgerWasEaten = true;
                    ScoreClass.score += 5;

                }
                
            }
        }
        public void EatAspirine(ref PictureBox Ameba, ref PictureBox Aspirine)
        {
            if (Ameba.Bounds.IntersectsWith(Aspirine.Bounds))
            {
                if (Health == 100)
                {
                    Aspirine.Hide();
                    Aspirine.Left = 500;
                    ItemClass.AspirineWasEaten = true;
                    ScoreClass.score += 5;
                }
                else if (Health != 100)
                {
                    Aspirine.Hide();
                    Aspirine.Left = 500;
                    Health = 100;
                    ItemClass.AspirineWasEaten = true;
                    ScoreClass.score += 5;
                }

            }
        }
        public void CheckTouchWithVirus(ref PictureBox Ameba, ref PictureBox Virus1, Form gameForm)
        {
            if (Ameba.Bounds.IntersectsWith(Virus1.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                }

            }
        }
        public void CheckTouchWithVirus(ref PictureBox Ameba, ref PictureBox Virus1, ref PictureBox Virus2, Form gameForm)
        {
            if (Ameba.Bounds.IntersectsWith(Virus1.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                }

            }
            else if (Ameba.Bounds.IntersectsWith(Virus2.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                };
            }
        }
        public void CheckTouchWithVirus(ref PictureBox Ameba, ref PictureBox Virus1, ref PictureBox Virus2, ref PictureBox Virus3, Form gameForm)
        {
            if (Ameba.Bounds.IntersectsWith(Virus1.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                }

            }
            else if (Ameba.Bounds.IntersectsWith(Virus2.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                };
            }
            else if (Ameba.Bounds.IntersectsWith(Virus3.Bounds))
            {
                Health -= 50;
                if (Health == 0 || Health < 0)
                {
                    Timer.Stop();
                    TimerForBurgerAndAspirine.Stop();
                    UpdateTimer.Stop();
                    GameState.IsGameOver = true;
                    GameState.IsLevelEasy = false;
                    GameState.IsLevelMedium = false;
                    GameState.IsLevelHard = false;
                    GameState.SetPositionForVirus = false;
                    if (!finalFormShown)
                    {
                        finalFormShown = true;
                        finalForm.Show();
                        gameForm.Close();
                    }
                };
            }
        }

    }
}
