namespace Ameba
{
    partial class FinalForm
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
            this.FinalFormLabel = new System.Windows.Forms.Label();
            this.GoHome = new System.Windows.Forms.PictureBox();
            this.ResultTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalFormLabel
            // 
            this.FinalFormLabel.AutoSize = true;
            this.FinalFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.FinalFormLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalFormLabel.Location = new System.Drawing.Point(54, 79);
            this.FinalFormLabel.Name = "FinalFormLabel";
            this.FinalFormLabel.Size = new System.Drawing.Size(277, 61);
            this.FinalFormLabel.TabIndex = 0;
            this.FinalFormLabel.Text = "Your score:";
            // 
            // GoHome
            // 
            this.GoHome.BackColor = System.Drawing.Color.Transparent;
            this.GoHome.Image = global::Ameba.Properties.Resources.gohome;
            this.GoHome.Location = new System.Drawing.Point(183, 292);
            this.GoHome.Name = "GoHome";
            this.GoHome.Size = new System.Drawing.Size(100, 96);
            this.GoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoHome.TabIndex = 2;
            this.GoHome.TabStop = false;
            this.GoHome.Click += new System.EventHandler(this.GoHome_Click_1);
            this.GoHome.MouseEnter += new System.EventHandler(this.GoHome_MouseEnter_1);
            this.GoHome.MouseLeave += new System.EventHandler(this.GoHome_MouseLeave_1);
            // 
            // ResultTimer
            // 
            this.ResultTimer.Enabled = true;
            this.ResultTimer.Interval = 10;
            this.ResultTimer.Tick += new System.EventHandler(this.ResultTimer_Tick);
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Ameba.Properties.Resources.bcg1;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.GoHome);
            this.Controls.Add(this.FinalFormLabel);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameba: The Game";
            ((System.ComponentModel.ISupportInitialize)(this.GoHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinalFormLabel;
        private System.Windows.Forms.PictureBox GoHome;
        private System.Windows.Forms.Timer ResultTimer;
    }
}