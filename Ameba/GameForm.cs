using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    public partial class GameForm : Form
    {

        Random random = new Random((int)DateTime.Now.Millisecond);

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameState.IsGameOver == false)
            {
                using AmebaClass ameba = new AmebaClass(Ameba);
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    ameba.MoveLeft();
                    ameba.EatBurger(ref Ameba, ref Burger);
                    ameba.EatAspirine(ref Ameba, ref Aspirine);
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    ameba.MoveRight();
                    ameba.EatBurger(ref Ameba, ref Burger);
                    ameba.EatAspirine(ref  Ameba, ref  Aspirine);
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    ameba.MoveUp();
                    ameba.EatBurger(ref Ameba, ref Burger);
                    ameba.EatAspirine(ref  Ameba, ref  Aspirine);
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    ameba.MoveDown();
                    ameba.EatBurger(ref Ameba, ref Burger);
                    ameba.EatAspirine(ref  Ameba, ref  Aspirine);
                }
            }
        }

        private void MoveVirus(ref PictureBox Virus)
        {
            using VirusClass virus = new VirusClass();
            int direction = random.Next(1, 5); 

            if (direction == 1 && Virus.Left > 0) 
            {
                virus.MoveLeft(Virus);
            }
            else if (direction == 2 && Virus.Right < 450)
            {
                virus.MoveRight(Virus);
            }
            else if (direction == 3 && Virus.Top != 0) 
            {
                virus.MoveUp(Virus);
            }
            else if (direction == 4 && Virus.Bottom < 450)
            {
                virus.MoveDown(Virus);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (GameState.IsLevelEasy == true && GameState.IsLevelMedium == false && GameState.IsLevelHard == false)
            {
                MoveVirus(ref Virus1);
                using AmebaClass ameba = new AmebaClass(Ameba);
                ameba.CheckTouchWithVirus(ref Ameba, ref Virus1, this);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == true && GameState.IsLevelHard == false)
            {
                MoveVirus(ref Virus1);
                using AmebaClass ameba = new AmebaClass(Ameba);
                ameba.CheckTouchWithVirus(ref Ameba, ref Virus1, ref Virus2, this);
                MoveVirus(ref Virus2);
                ameba.CheckTouchWithVirus(ref Ameba, ref Virus1, ref Virus2, this);
            }
            else if (GameState.IsLevelEasy == false && GameState.IsLevelMedium == false && GameState.IsLevelHard == true)
            {
                MoveVirus(ref Virus1);
                using AmebaClass ameba = new AmebaClass(Ameba);
                ameba.CheckTouchWithVirus(ref Ameba, ref Virus1, ref Virus2, ref Virus3, this);
                MoveVirus(ref Virus2);
                ameba.CheckTouchWithVirus(ref Ameba, ref Virus1, ref Virus2, ref Virus3, this);
                MoveVirus(ref Virus3);
            }

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            using ScoreClass score = new ScoreClass();
            score.GetScore(ref ScoreLabel, ref HealthLabel);
        }

        private void TimerForBurgerAndAspirine_Tick(object sender, EventArgs e)
        {
            if (ItemClass.BurgerWasEaten == true)
            {
                ItemClass.BurgerWasEaten = false;
                using ItemClass aspirine = new ItemClass();
                aspirine.SetPositionForAspirine(ref Aspirine);
            }
            if (ItemClass.AspirineWasEaten == true)
            {
                ItemClass.AspirineWasEaten = false;
                using ItemClass burger = new ItemClass();
                burger.SetPositionForBurger(ref Burger);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (GameState.SetPositionForVirus == false)
            {
                GameState.SetPositionForVirus = true;
                VirusClass virus = new VirusClass();
                virus.StartPositionForViruses(ref Virus1, ref Virus2, ref Virus3);
            }
        }
    }
}
