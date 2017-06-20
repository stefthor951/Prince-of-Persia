namespace RunningGame.Screens
{
    partial class WinScreen
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.nameText2 = new System.Windows.Forms.Label();
            this.nameText3 = new System.Windows.Forms.Label();
            this.rightSword = new System.Windows.Forms.PictureBox();
            this.leftSword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Gold;
            this.menuLabel.Location = new System.Drawing.Point(574, 316);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(268, 65);
            this.menuLabel.TabIndex = 7;
            this.menuLabel.Text = "MAIN MENU";
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.ForeColor = System.Drawing.Color.Gold;
            this.restartLabel.Location = new System.Drawing.Point(159, 316);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(210, 65);
            this.restartLabel.TabIndex = 6;
            this.restartLabel.Text = "RESTART";
            // 
            // scoreOutput
            // 
            this.scoreOutput.AutoSize = true;
            this.scoreOutput.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.ForeColor = System.Drawing.Color.White;
            this.scoreOutput.Location = new System.Drawing.Point(414, 269);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(172, 34);
            this.scoreOutput.TabIndex = 5;
            this.scoreOutput.Text = "Final Score: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(228, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(545, 61);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "YOU GOT A HIGHSCORE!";
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.Font = new System.Drawing.Font("Segoe Script", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText1.ForeColor = System.Drawing.Color.White;
            this.nameText1.Location = new System.Drawing.Point(350, 135);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(81, 87);
            this.nameText1.TabIndex = 8;
            this.nameText1.Text = "A";
            // 
            // nameText2
            // 
            this.nameText2.AutoSize = true;
            this.nameText2.Font = new System.Drawing.Font("Segoe Script", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText2.ForeColor = System.Drawing.Color.White;
            this.nameText2.Location = new System.Drawing.Point(460, 135);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(81, 87);
            this.nameText2.TabIndex = 9;
            this.nameText2.Text = "A";
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.Font = new System.Drawing.Font("Segoe Script", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.White;
            this.nameText3.Location = new System.Drawing.Point(570, 135);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(81, 87);
            this.nameText3.TabIndex = 10;
            this.nameText3.Text = "A";
            // 
            // rightSword
            // 
            this.rightSword.BackColor = System.Drawing.Color.Transparent;
            this.rightSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitarflip;
            this.rightSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightSword.Location = new System.Drawing.Point(249, 269);
            this.rightSword.Name = "rightSword";
            this.rightSword.Size = new System.Drawing.Size(51, 24);
            this.rightSword.TabIndex = 12;
            this.rightSword.TabStop = false;
            // 
            // leftSword
            // 
            this.leftSword.BackColor = System.Drawing.Color.Transparent;
            this.leftSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitar;
            this.leftSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftSword.Location = new System.Drawing.Point(102, 269);
            this.leftSword.Name = "leftSword";
            this.leftSword.Size = new System.Drawing.Size(51, 24);
            this.leftSword.TabIndex = 11;
            this.leftSword.TabStop = false;
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.rightSword);
            this.Controls.Add(this.leftSword);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.titleLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(1000, 400);
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WinScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WinScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.PictureBox rightSword;
        private System.Windows.Forms.PictureBox leftSword;
    }
}
