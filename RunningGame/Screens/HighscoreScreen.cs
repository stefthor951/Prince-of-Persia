using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace RunningGame.Screens
{
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            //outputs highscores in format: (Position). NAME score 
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                //Put the first 5 scores on the left label
                if (i < 5)
                {
                    top5Output.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].score + "\n";
                }
                //Put the next 5 on the right label
                else if (i >= 5 && i < 10)
                {
                    //for the tenth score remove a space, this will keep it lined up with the other scores
                    if ((i + 1) == 10)
                    {
                        next5Output.Text += (i + 1) + ". " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].score + "\n";
                    }
                    else
                    {
                        next5Output.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].score + "\n";
                    }
                }
            }
        }

        private void HighscoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();
            switch (e.KeyCode)
            {
                case Keys.Space:

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
                case Keys.Escape:

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
            }
        }
    }
}
