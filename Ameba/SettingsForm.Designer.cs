namespace Ameba
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NextLang = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NextLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(221, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language:";
            // 
            // NextLang
            // 
            this.NextLang.BackColor = System.Drawing.Color.Transparent;
            this.NextLang.Image = global::Ameba.Properties.Resources.ArrowToRight_removebg_preview;
            this.NextLang.Location = new System.Drawing.Point(513, 151);
            this.NextLang.Name = "NextLang";
            this.NextLang.Size = new System.Drawing.Size(90, 52);
            this.NextLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextLang.TabIndex = 1;
            this.NextLang.TabStop = false;
            this.NextLang.Click += new System.EventHandler(this.NextLang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(275, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Music:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(422, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "On";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitPictureBox.Image = global::Ameba.Properties.Resources.exit;
            this.ExitPictureBox.Location = new System.Drawing.Point(745, 5);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(50, 50);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 4;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseEnter += new System.EventHandler(this.ExitPictureBox_MouseEnter);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ameba.Properties.Resources.bcgr1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextLang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.NextLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NextLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ExitPictureBox;
    }
}