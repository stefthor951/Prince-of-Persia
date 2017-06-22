namespace RunningGame.Screens
{
    partial class PauseScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pauseBackground = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pauseBackground
            // 
            this.pauseBackground.BackColor = System.Drawing.Color.Black;
            this.pauseBackground.Location = new System.Drawing.Point(7, 7);
            this.pauseBackground.Name = "pauseBackground";
            this.pauseBackground.Size = new System.Drawing.Size(286, 136);
            this.pauseBackground.TabIndex = 0;
            this.pauseBackground.Text = "label1";
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.BackColor = System.Drawing.Color.Black;
            this.quitLabel.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLabel.ForeColor = System.Drawing.Color.White;
            this.quitLabel.Location = new System.Drawing.Point(89, 13);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(101, 44);
            this.quitLabel.TabIndex = 1;
            this.quitLabel.Text = "Quit?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yes";
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.pauseBackground);
            this.Name = "PauseScreen";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pauseBackground;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.Label label1;
    }
}
