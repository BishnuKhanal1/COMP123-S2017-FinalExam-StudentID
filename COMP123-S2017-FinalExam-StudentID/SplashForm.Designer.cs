namespace COMP123_S2017_FinalExam_StudentID
{
    partial class SplashFormCardGame
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
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashFormWelcomeLabel = new System.Windows.Forms.Label();
            this.WishingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashFormWelcomeLabel
            // 
            this.SplashFormWelcomeLabel.AutoSize = true;
            this.SplashFormWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashFormWelcomeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.SplashFormWelcomeLabel.Location = new System.Drawing.Point(62, 93);
            this.SplashFormWelcomeLabel.Name = "SplashFormWelcomeLabel";
            this.SplashFormWelcomeLabel.Size = new System.Drawing.Size(461, 62);
            this.SplashFormWelcomeLabel.TabIndex = 0;
            this.SplashFormWelcomeLabel.Text = "Welcome\r\n To My Highest  Card Pick Gaming";
            this.SplashFormWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WishingLabel
            // 
            this.WishingLabel.AutoSize = true;
            this.WishingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WishingLabel.ForeColor = System.Drawing.Color.Maroon;
            this.WishingLabel.Location = new System.Drawing.Point(124, 289);
            this.WishingLabel.Name = "WishingLabel";
            this.WishingLabel.Size = new System.Drawing.Size(306, 31);
            this.WishingLabel.TabIndex = 1;
            this.WishingLabel.Text = "Have a Wonderful Day";
            this.WishingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashFormCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.WishingLabel);
            this.Controls.Add(this.SplashFormWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashFormCardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label SplashFormWelcomeLabel;
        private System.Windows.Forms.Label WishingLabel;
    }
}