using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RunningGame.Screens
{
    public partial class WinScreen : UserControl
    {
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;

        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        List<string> letterStrings = new List<string>();
        string placeholder;
        int index;

        SoundPlayer winMusic;

        List<Label> labelList = new List<Label>();

        private void WinScreen_Load(object sender, EventArgs e)
        {
            winMusic = new SoundPlayer(Properties.Resources.WinMusic);
            winMusic.Play();
            scoreOutput.Text = "You got " + Form1.currentScore + " points!";

            MoveArrows(null);

            letterStrings.Add(placeholder);
            letterStrings.Add(placeholder);
            letterStrings.Add(placeholder);

            labelList.Add(nameText1);
            labelList.Add(nameText2);
            labelList.Add(nameText3);
        }

        int selected = 4, lastSelected;

        private void WinScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastSelected = selected;

            if (leftArrowDown || rightArrowDown)
            {
                lastArrowDown = true;
            }
            else
            {
                lastArrowDown = false;
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    //Form1.gameTheme.PlayLooping();

                    Form form = this.FindForm();
                    MenuScreen ms = new MenuScreen();
                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
                default:
                    break;
            }
            if (lastArrowDown == false)
            {
                if (rightArrowDown == true)
                {
                    if (selected == 4)
                    {
                        selected = 0;
                    }
                    else
                    {
                        selected++;
                    }
                }

                if (leftArrowDown == true)
                {
                    if (selected == 0)
                    {
                        selected = 4;
                    }
                    else
                    {
                        selected--;
                    }
                }
            }

            switch (selected)
            {
                case 0:
                    MoveArrows(nameText1);
                    MoveSwords(null);
                    LetterShift(0);
                    break;
                case 1:
                    MoveArrows(nameText2);
                    MoveSwords(null);
                    LetterShift(1);
                    break;
                case 2:
                    MoveArrows(nameText3);
                    MoveSwords(null);
                    LetterShift(2);
                    break;
                case 3:
                    MoveArrows(null);
                    MoveSwords(menuLabel);

                    if (spaceDown == true)
                    {

                        Highscore hs = new Highscore(nameText1.Text + nameText2.Text + nameText3.Text, Convert.ToString(Form1.currentScore));
                        hs.save(hs);
                        hs.saveScores(Form1.highscoreList);

                        // Goes to the game screen

                        Form form = this.FindForm();
                        MenuScreen ms = new MenuScreen();

                        ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                        form.Controls.Add(ms);
                        form.Controls.Remove(this);
                    }
                    break;

                case 4:
                    MoveArrows(null);
                    MoveSwords(restartLabel);

                    if (spaceDown == true)
                    {
                        winMusic.Stop();
                        Form1.gameTheme.PlayLooping();

                        Highscore hs = new Highscore(nameText1.Text + nameText2.Text + nameText3.Text, Convert.ToString(Form1.currentScore));

                        hs.save(hs);
                        hs.saveScores(Form1.highscoreList);

                        // Goes to the main menu screen

                        Form form = this.FindForm();
                        Screens.GameScreen gs = new Screens.GameScreen();

                        gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                        form.Controls.Add(gs);
                        form.Controls.Remove(this);
                    }
                    break;
            }
        }

        private void WinScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        bool lastArrowDown;

        public WinScreen()
        {
            InitializeComponent();
            MoveSwords(restartLabel);
        }

        public void LetterShift(int i)
        {
            if (upArrowDown)
            {
                index--;
                if (index == -1)
                {
                    index = 25;
                }
                letterStrings[i] = alphabet.Substring(index, 1);
                labelList[i].Text = letterStrings[i];
            }
            if (downArrowDown)
            {
                index++;
                if (index == 26)
                {
                    index = 0;
                }
                letterStrings[i] = alphabet.Substring(index, 1);
                labelList[i].Text = letterStrings[i];
            }
        }

        public void MoveSwords(Label l)
        {
            Point leftSwordPoint;
            Point rightSwordPoint;

            if (l == null)
            {
                leftSwordPoint = new Point(-100, 337);
                leftSword.Location = leftSwordPoint;
                rightSwordPoint = new Point(-100, 337);
                rightSword.Location = rightSwordPoint;
            }
            else
            {
                leftSwordPoint = new Point(l.Location.X - leftSword.Width - 5, l.Location.Y + ((l.Height - leftSword.Height) / 2));
                leftSword.Location = leftSwordPoint;
                rightSwordPoint = new Point(l.Location.X + l.Width + 5, l.Location.Y + ((l.Height - leftSword.Height) / 2));
                rightSword.Location = rightSwordPoint;
            }
        }

        public void MoveArrows(Label l)
        {
            Point topArrowPoint;
            Point bottomArrowPoint;
            if (l == null)
            {
                topArrowPoint = new Point(-100, 337);
                topArrow.Location = topArrowPoint;
                bottomArrowPoint = new Point(-100, 337);
                bottomArrow.Location = bottomArrowPoint;
            }
            else
            {
                topArrowPoint = new Point(l.Location.X + 20, l.Location.Y - 20);
                topArrow.Location = topArrowPoint;
                bottomArrowPoint = new Point(l.Location.X + 20, l.Location.Y + l.Height); ;
                bottomArrow.Location = bottomArrowPoint;
            }
        }
    }
}
