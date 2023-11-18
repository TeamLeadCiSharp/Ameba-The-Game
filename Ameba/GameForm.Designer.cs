namespace Ameba
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ameba = new System.Windows.Forms.PictureBox();
            this.GameBackGround = new System.Windows.Forms.PictureBox();
            this.Virus1 = new System.Windows.Forms.PictureBox();
            this.Virus2 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.HelpPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.Burger = new System.Windows.Forms.PictureBox();
            this.Aspirine = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerForBurgerAndAspirine = new System.Windows.Forms.Timer(this.components);
            this.Virus3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ameba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aspirine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus3)).BeginInit();
            this.SuspendLayout();
            // 
            // Ameba
            // 
            this.Ameba.BackColor = System.Drawing.Color.Transparent;
            this.Ameba.Image = global::Ameba.Properties.Resources.ameba;
            this.Ameba.Location = new System.Drawing.Point(250, 400);
            this.Ameba.Name = "Ameba";
            this.Ameba.Size = new System.Drawing.Size(48, 48);
            this.Ameba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ameba.TabIndex = 1;
            this.Ameba.TabStop = false;
            // 
            // GameBackGround
            // 
            this.GameBackGround.BackColor = System.Drawing.Color.Transparent;
            this.GameBackGround.Image = global::Ameba.Properties.Resources.Background1;
            this.GameBackGround.Location = new System.Drawing.Point(0, 0);
            this.GameBackGround.Name = "GameBackGround";
            this.GameBackGround.Size = new System.Drawing.Size(500, 500);
            this.GameBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameBackGround.TabIndex = 2;
            this.GameBackGround.TabStop = false;
            // 
            // Virus1
            // 
            this.Virus1.BackColor = System.Drawing.Color.Transparent;
            this.Virus1.Image = global::Ameba.Properties.Resources.virus;
            this.Virus1.Location = new System.Drawing.Point(50, 50);
            this.Virus1.Name = "Virus1";
            this.Virus1.Size = new System.Drawing.Size(48, 48);
            this.Virus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Virus1.TabIndex = 3;
            this.Virus1.TabStop = false;
            // 
            // Virus2
            // 
            this.Virus2.BackColor = System.Drawing.Color.Transparent;
            this.Virus2.Image = global::Ameba.Properties.Resources.virus;
            this.Virus2.Location = new System.Drawing.Point(250, 50);
            this.Virus2.Name = "Virus2";
            this.Virus2.Size = new System.Drawing.Size(48, 48);
            this.Virus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Virus2.TabIndex = 4;
            this.Virus2.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HelpPictureBox
            // 
            this.HelpPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HelpPictureBox.BackgroundImage = global::Ameba.Properties.Resources.helpImg;
            this.HelpPictureBox.Location = new System.Drawing.Point(500, 0);
            this.HelpPictureBox.Name = "HelpPictureBox";
            this.HelpPictureBox.Size = new System.Drawing.Size(137, 500);
            this.HelpPictureBox.TabIndex = 5;
            this.HelpPictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Image = global::Ameba.Properties.Resources.helpImg;
            this.ScoreLabel.Location = new System.Drawing.Point(500, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(71, 24);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score:";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealthLabel.Image = global::Ameba.Properties.Resources.helpImg;
            this.HealthLabel.Location = new System.Drawing.Point(501, 24);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(70, 24);
            this.HealthLabel.TabIndex = 7;
            this.HealthLabel.Text = "Health";
            // 
            // Burger
            // 
            this.Burger.BackColor = System.Drawing.Color.Transparent;
            this.Burger.Image = global::Ameba.Properties.Resources.burger;
            this.Burger.Location = new System.Drawing.Point(400, 250);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(48, 48);
            this.Burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Burger.TabIndex = 8;
            this.Burger.TabStop = false;
            // 
            // Aspirine
            // 
            this.Aspirine.BackColor = System.Drawing.Color.Transparent;
            this.Aspirine.Image = global::Ameba.Properties.Resources.aspirin;
            this.Aspirine.Location = new System.Drawing.Point(100, 150);
            this.Aspirine.Name = "Aspirine";
            this.Aspirine.Size = new System.Drawing.Size(48, 48);
            this.Aspirine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Aspirine.TabIndex = 9;
            this.Aspirine.TabStop = false;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 10;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // TimerForBurgerAndAspirine
            // 
            this.TimerForBurgerAndAspirine.Enabled = true;
            this.TimerForBurgerAndAspirine.Interval = 30000;
            this.TimerForBurgerAndAspirine.Tick += new System.EventHandler(this.TimerForBurgerAndAspirine_Tick);
            // 
            // Virus3
            // 
            this.Virus3.BackColor = System.Drawing.Color.Transparent;
            this.Virus3.Image = global::Ameba.Properties.Resources.virus;
            this.Virus3.Location = new System.Drawing.Point(400, 50);
            this.Virus3.Name = "Virus3";
            this.Virus3.Size = new System.Drawing.Size(48, 48);
            this.Virus3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Virus3.TabIndex = 10;
            this.Virus3.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ameba.Properties.Resources.helpBg;
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.Virus3);
            this.Controls.Add(this.Virus2);
            this.Controls.Add(this.Aspirine);
            this.Controls.Add(this.Burger);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.HelpPictureBox);
            this.Controls.Add(this.Virus1);
            this.Controls.Add(this.Ameba);
            this.Controls.Add(this.GameBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameba: The Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ameba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aspirine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox Ameba;
        private System.Windows.Forms.PictureBox GameBackGround;
        protected System.Windows.Forms.PictureBox Virus1;
        protected System.Windows.Forms.PictureBox Virus2;
        private System.Windows.Forms.PictureBox HelpPictureBox;
        protected System.Windows.Forms.Label ScoreLabel;
        protected System.Windows.Forms.Label HealthLabel;
        protected System.Windows.Forms.PictureBox Burger;
        public System.Windows.Forms.Timer Timer;
        protected System.Windows.Forms.PictureBox Aspirine;
        public System.Windows.Forms.Timer UpdateTimer;
        public System.Windows.Forms.Timer TimerForBurgerAndAspirine;
        protected System.Windows.Forms.PictureBox Virus3;
    }
}