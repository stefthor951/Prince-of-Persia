namespace RunningGame.Screens
{
    partial class InstructionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.joystick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.joystick)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(281, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "How to Play";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(64, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(792, 339);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(238, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 53);
            this.label3.TabIndex = 11;
            this.label3.Text = "Move";
            // 
            // joystick
            // 
            this.joystick.BackColor = System.Drawing.Color.SaddleBrown;
            this.joystick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("joystick.BackgroundImage")));
            this.joystick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joystick.Location = new System.Drawing.Point(186, 203);
            this.joystick.Name = "joystick";
            this.joystick.Size = new System.Drawing.Size(275, 185);
            this.joystick.TabIndex = 10;
            this.joystick.TabStop = false;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joystick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.joystick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox joystick;
        private System.Windows.Forms.Label label3;
    }
}
