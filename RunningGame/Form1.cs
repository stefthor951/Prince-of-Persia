//Created by Stefan Thorburn
//June 2017
//Simple endless running game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using RunningGame.Screens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace RunningGame
{
    public partial class Form1 : Form
    {

        public static List<Highscore> highscoreList = new List<Highscore>();
        public static int currentScore;
        public static SoundPlayer gameTheme = new SoundPlayer(Properties.Resources.Theme);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            gameTheme.PlayLooping();


            //attempts to load all saved highscores
            try
            {
                loadHighscores();
            }

            //if the file did not exist, create the file
            catch
            {
                XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

                writer.WriteStartElement("highscoreList");
                writer.WriteEndElement();

                writer.Close();
            }

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void loadHighscores() //method for loading any saved highscores in the highscoreDB xml file
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new Highscore(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                    }
                }
                highscoreList.Add(hs);
            }
        }
    }
}
