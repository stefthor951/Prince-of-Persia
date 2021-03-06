﻿namespace RunningGame.Screens
{
    partial class MenuScreen
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
            this.startLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightSword = new System.Windows.Forms.PictureBox();
            this.leftSword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.startLabel.Location = new System.Drawing.Point(52, 421);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(128, 36);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "START";
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.instructionLabel.Location = new System.Drawing.Point(259, 422);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(196, 35);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "CONTROLS";
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLabel.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.highscoreLabel.Location = new System.Drawing.Point(534, 421);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(230, 36);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "HIGHSCORES";
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.exitLabel.Location = new System.Drawing.Point(843, 422);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(97, 35);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "EXIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 106);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prince of Persia";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(313, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escape from Agrabah";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RunningGame.Properties.Resources.Agrabah_cropped;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(200, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 240);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // rightSword
            // 
            this.rightSword.BackColor = System.Drawing.Color.Transparent;
            this.rightSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitarflip;
            this.rightSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightSword.Location = new System.Drawing.Point(85, 316);
            this.rightSword.Name = "rightSword";
            this.rightSword.Size = new System.Drawing.Size(51, 24);
            this.rightSword.TabIndex = 5;
            this.rightSword.TabStop = false;
            // 
            // leftSword
            // 
            this.leftSword.BackColor = System.Drawing.Color.Transparent;
            this.leftSword.BackgroundImage = global::RunningGame.Properties.Resources.scimitar;
            this.leftSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftSword.Location = new System.Drawing.Point(29, 316);
            this.leftSword.Name = "leftSword";
            this.leftSword.Size = new System.Drawing.Size(51, 24);
            this.leftSword.TabIndex = 4;
            this.leftSword.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightSword);
            this.Controls.Add(this.leftSword);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.startLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1000, 500);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MenuScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox leftSword;
        private System.Windows.Forms.PictureBox rightSword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
