using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    public class ItemClass: GameForm
    {
        public static bool BurgerWasEaten = false;
        public static bool AspirineWasEaten = false;
        public void SetPositionForBurger(ref PictureBox Burger)
        {
            BurgerWasEaten = false;
            Random rndX = new Random();
            Random rndY = new Random();

            int BurgerPosX = rndX.Next(0, 11) * 50;
            int BurgerPosY = rndY.Next(0, 11) * 50;

            Burger.Left = BurgerPosX;
            Burger.Top = BurgerPosY;
            Burger.Show();
        }
        public void SetPositionForAspirine(ref PictureBox Aspirine)
        {
            AspirineWasEaten = false;
            Random rndX = new Random();
            Random rndY = new Random();

            int AspirinePosX = rndX.Next(0, 11) * 50;
            int AspirinePosY = rndY.Next(0, 11) * 50;

            Aspirine.Left = AspirinePosX;
            Aspirine.Top = AspirinePosY;
            Aspirine.Show();
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.Ameba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aspirine)).BeginInit();
            this.SuspendLayout();
            // 
            // Virus1
            // 
            this.Virus1.Location = new System.Drawing.Point(50, 100);
            // 
            // Virus2
            // 
            this.Virus2.Location = new System.Drawing.Point(350, 150);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Size = new System.Drawing.Size(88, 24);
            this.ScoreLabel.Text = "Score: 0";
            // 
            // HealthLabel
            // 
            this.HealthLabel.Size = new System.Drawing.Size(115, 24);
            this.HealthLabel.Text = "Health: 100";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ItemClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Name = "ItemClass";
            ((System.ComponentModel.ISupportInitialize)(this.Ameba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aspirine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
