using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningGame.Screens
{
    public partial class LoseScreen : UserControl
    {
        int index = 0;
        bool leftKeyDown, rightKeyDown, choiceChanged = false;
        Graphics g;

        public LoseScreen()
        {
            InitializeComponent();
            

            Point leftSwordPoint = new Point(restartLabel.Location.X - leftSword.Width - 5, 314);
            leftSword.Location = leftSwordPoint;
            Point rightSwordPoint = new Point(restartLabel.Location.X + restartLabel.Width + 5, 314);
            rightSword.Location = rightSwordPoint;
        }

        private void LoseScreen_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DimGray);
            g.FillEllipse(brush, losePicture.Location.X - 50, losePicture.Location.Y + (losePicture.Height - 25), losePicture.Location.X + losePicture.Width + 50, losePicture.Location.Y + (losePicture.Height + 25));

            scoreLabel.Text = "You ran " + Form1.currentScore + " metres";
            Point labelPoint = new Point(this.Width / 2 - (scoreLabel.Width / 2), scoreLabel.Location.Y);
            scoreLabel.Location = labelPoint;
        }

        private void LoseScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKeyDown = false;
                    choiceChanged = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    choiceChanged = false;
                    break;
            }
        }

        private void LoseScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form form = this.FindForm();
            MenuScreen ms = new MenuScreen();
            //to make sure that if you click to the bottom or top you will go to the other end instead of just stopping
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (leftKeyDown == false)
                    {
                        leftKeyDown = true;
                        if (index != 0)
                            index--;
                        else
                        {
                            index = 1;
                        }
                    }
                    break;
                case Keys.Right:
                    if (rightKeyDown == false)
                    {
                        rightKeyDown = true;
                        if (index != 1)
                            index++;
                        else
                        {
                            index = 0;
                        }
                    }
                    break;

                case Keys.Escape:
                    //MenuScreen ms = new MenuScreen();

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;

                //Selecting an option on the main menu
                case Keys.Space:
                    switch (index)
                    {
                        //If the restart button is selected
                        case 0:

                            GameScreen gs = new GameScreen();
                            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                            form.Controls.Add(gs);
                            form.Controls.Remove(this);

                            break;

                        //If the main menu button is selected
                        case 1:

                            //MenuScreen ms = new MenuScreen();

                            form.Controls.Add(ms);
                            form.Controls.Remove(this);

                            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                            break;
                    }
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        Point leftSwordPoint = new Point(restartLabel.Location.X - leftSword.Width - 5, 314);
                        leftSword.Location = leftSwordPoint;
                        Point rightSwordPoint = new Point(restartLabel.Location.X + restartLabel.Width + 5, 314);
                        rightSword.Location = rightSwordPoint;
                    }
                    break;
                case 1:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        Point leftSwordPoint = new Point(menuLabel.Location.X - leftSword.Width - 5, 314);
                        leftSword.Location = leftSwordPoint;
                        Point rightSwordPoint = new Point(menuLabel.Location.X + menuLabel.Width + 5, 314);
                        rightSword.Location = rightSwordPoint;
                    }
                    break;
            }
        }

    }
}
