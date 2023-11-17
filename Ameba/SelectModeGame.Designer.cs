namespace Ameba
{
    partial class SelectModeGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.HardLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ameba.Properties.Resources.ArrowToLeft;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EasyLabel.Location = new System.Drawing.Point(268, 105);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(58, 28);
            this.EasyLabel.TabIndex = 2;
            this.EasyLabel.Text = "Easy";
            this.EasyLabel.Click += new System.EventHandler(this.EasyLabel_Click);
            this.EasyLabel.MouseEnter += new System.EventHandler(this.EasyLabel_MouseEnter);
            this.EasyLabel.MouseLeave += new System.EventHandler(this.EasyLabel_MouseLeave);
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.BackColor = System.Drawing.Color.Transparent;
            this.MediumLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MediumLabel.Location = new System.Drawing.Point(244, 176);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(101, 28);
            this.MediumLabel.TabIndex = 3;
            this.MediumLabel.Text = "Medium";
            this.MediumLabel.Click += new System.EventHandler(this.MediumLabel_Click);
            this.MediumLabel.MouseEnter += new System.EventHandler(this.MediumLabel_MouseEnter);
            this.MediumLabel.MouseLeave += new System.EventHandler(this.MediumLabel_MouseLeave);
            // 
            // HardLabel
            // 
            this.HardLabel.AutoSize = true;
            this.HardLabel.BackColor = System.Drawing.Color.Transparent;
            this.HardLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HardLabel.Location = new System.Drawing.Point(262, 248);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(64, 28);
            this.HardLabel.TabIndex = 4;
            this.HardLabel.Text = "Hard";
            this.HardLabel.Click += new System.EventHandler(this.HardLabel_Click);
            this.HardLabel.MouseEnter += new System.EventHandler(this.HardLabel_MouseEnter);
            this.HardLabel.MouseLeave += new System.EventHandler(this.HardLabel_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ameba.Properties.Resources.select_level;
            this.pictureBox2.Location = new System.Drawing.Point(0, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 400);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // SelectModeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ameba.Properties.Resources.select_level;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.EasyLabel);
            this.Controls.Add(this.HardLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectModeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Mode Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Label HardLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}