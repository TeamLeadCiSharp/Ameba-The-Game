namespace Ameba
{
    partial class HomeScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.StartBox = new System.Windows.Forms.PictureBox();
            this.SettingsBox = new System.Windows.Forms.PictureBox();
            this.InfoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Location = new System.Drawing.Point(250, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(312, 42);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Ameba: The Game";
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitPictureBox.Image = global::Ameba.Properties.Resources.exit;
            this.ExitPictureBox.Location = new System.Drawing.Point(745, 5);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(50, 50);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 2;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseEnter += new System.EventHandler(this.ExitPictureBox_MouseEnter);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            // 
            // StartBox
            // 
            this.StartBox.BackColor = System.Drawing.Color.Transparent;
            this.StartBox.Image = global::Ameba.Properties.Resources.play;
            this.StartBox.Location = new System.Drawing.Point(350, 200);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(100, 100);
            this.StartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartBox.TabIndex = 3;
            this.StartBox.TabStop = false;
            this.StartBox.Click += new System.EventHandler(this.StartBox_Click);
            this.StartBox.MouseEnter += new System.EventHandler(this.StartBox_MouseEnter);
            this.StartBox.MouseLeave += new System.EventHandler(this.StartBox_MouseLeave);
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBox.Image = global::Ameba.Properties.Resources.settings;
            this.SettingsBox.Location = new System.Drawing.Point(217, 210);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(80, 80);
            this.SettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsBox.TabIndex = 4;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Click += new System.EventHandler(this.SettingsBox_Click);
            this.SettingsBox.MouseEnter += new System.EventHandler(this.SettingsBox_MouseEnter);
            this.SettingsBox.MouseLeave += new System.EventHandler(this.SettingsBox_MouseLeave);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.Transparent;
            this.InfoBox.Image = global::Ameba.Properties.Resources.info;
            this.InfoBox.Location = new System.Drawing.Point(511, 210);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(80, 80);
            this.InfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoBox.TabIndex = 5;
            this.InfoBox.TabStop = false;
            this.InfoBox.Click += new System.EventHandler(this.InfoBox_Click);
            this.InfoBox.MouseEnter += new System.EventHandler(this.InfoBox_MouseEnter);
            this.InfoBox.MouseLeave += new System.EventHandler(this.InfoBox_MouseLeave);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ameba.Properties.Resources.bcgr;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameba";
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox StartBox;
        private System.Windows.Forms.PictureBox SettingsBox;
        private System.Windows.Forms.PictureBox InfoBox;
    }
}

