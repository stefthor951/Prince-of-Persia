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
    public partial class MenuScreen : UserControl
    {
        int index = 0;
        bool leftKeyDown, rightKeyDown, choiceChanged = false;

        public MenuScreen()
        {
            InitializeComponent();

            MoveSwords(startLabel);

        }

        private void MenuScreen_KeyUp(object sender, KeyEventArgs e)
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

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form form = this.FindForm();
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
                            index = 3;
                        }
                    }
                    break;
                case Keys.Right:
                    if (rightKeyDown == false)
                    {
                        rightKeyDown = true;
                        if (index != 3)
                            index++;
                        else
                        {
                            index = 0;
                        }
                    }
                    break;

                case Keys.Escape:
                    Application.Exit();
                    break;

                //Selecting an option on the main menu
                case Keys.Space:
                    switch (index)
                    {
                        //If the start button is selected
                        case 0:

                            GameScreen gs = new GameScreen();
                            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                            form.Controls.Add(gs);
                            form.Controls.Remove(this);

                            break;

                        //If the instruction button is selected
                        case 1:

                            InstructionScreen ins = new InstructionScreen();

                            form.Controls.Add(ins);
                            form.Controls.Remove(this);

                            ins.Location = new Point((form.Width - ins.Width) / 2, (form.Height - ins.Height) / 2);
                            break;


                        //If the highscore button is selected
                        case 2:

                            HighscoreScreen hs = new HighscoreScreen();
                            form.Controls.Add(hs);
                            form.Controls.Remove(this);

                            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

                            break;

                        //If the exit button is selected
                        case 3:

                            Application.Exit();
                            break;
                    }
                    break;
            }

            //Move the sword pictures to the correct label
            switch (index)
            {
                case 0:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        MoveSwords(startLabel);
                    }
                    break;
                case 1:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        MoveSwords(instructionLabel);
                    }
                    break;
                case 2:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        MoveSwords(highscoreLabel);
                    }
                    break;
                case 3:
                    if (choiceChanged == false)
                    {
                        choiceChanged = true;
                        MoveSwords(exitLabel);
                    }
                    break;
            }
        }

        //Generic method for placing the swords around a label
        public void MoveSwords(Label l)
        {
            Point leftSwordPoint;
            Point rightSwordPoint;

            leftSwordPoint = new Point(l.Location.X - leftSword.Width - 5, l.Location.Y + ((l.Height - leftSword.Height) / 2) + 3);
            leftSword.Location = leftSwordPoint;
            rightSwordPoint = new Point(l.Location.X + l.Width, l.Location.Y + ((l.Height - leftSword.Height) / 2) + 3);
            rightSword.Location = rightSwordPoint;
        }
    }
}
