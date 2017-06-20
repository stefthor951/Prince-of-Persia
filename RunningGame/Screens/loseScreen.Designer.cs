namespace RunningGame.Screens
{
    partial class LoseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoseScreen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.rightSword = new System.Windows.Forms.PictureBox();
            this.leftSword = new System.Windows.Forms.PictureBox();
            this.losePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(342, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(317, 81);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "YOU LOSE";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(414, 101);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(172, 34);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Final Score: ";
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.ForeColor = System.Drawing.Color.Gold;
            this.restartLabel.Location = new System.Drawing.Point(176, 304);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(194, 44);
            this.restartLabel.TabIndex = 2;
            this.restartLabel.Text = "RESTART";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Gold;
            this.menuLabel.Location = new System.Drawing.Point(591, 304);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(234, 44);
            this.menuLabel.TabIndex = 3;
            this.menuLabel.Text = "MAIN MENU";
            // 
            // rightSword
            // 
            this.rightSword.BackColor = System.Drawing.Color.Transparent;
            this.rightSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitarflip;
            this.rightSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightSword.Location = new System.Drawing.Point(238, 255);
            this.rightSword.Name = "rightSword";
            this.rightSword.Size = new System.Drawing.Size(51, 24);
            this.rightSword.TabIndex = 7;
            this.rightSword.TabStop = false;
            // 
            // leftSword
            // 
            this.leftSword.BackColor = System.Drawing.Color.Transparent;
            this.leftSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitar;
            this.leftSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftSword.Location = new System.Drawing.Point(91, 255);
            this.leftSword.Name = "leftSword";
            this.leftSword.Size = new System.Drawing.Size(51, 24);
            this.leftSword.TabIndex = 6;
            this.leftSword.TabStop = false;
            // 
            // losePicture
            // 
            this.losePicture.BackColor = System.Drawing.Color.Transparent;
            this.losePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("losePicture.BackgroundImage")));
            this.losePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.losePicture.Location = new System.Drawing.Point(443, 197);
            this.losePicture.Name = "losePicture";
            this.losePicture.Size = new System.Drawing.Size(115, 82);
            this.losePicture.TabIndex = 4;
            this.losePicture.TabStop = false;
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.rightSword);
            this.Controls.Add(this.leftSword);
            this.Controls.Add(this.losePicture);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(1000, 400);
            this.Load += new System.EventHandler(this.LoseScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoseScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LoseScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.PictureBox losePicture;
        private System.Windows.Forms.PictureBox rightSword;
        private System.Windows.Forms.PictureBox leftSword;
    }
}
