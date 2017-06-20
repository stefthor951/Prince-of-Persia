using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunningGame.Classes;
using System.Windows.Forms;
using System.Threading;

namespace RunningGame.Screens
{
    public partial class GameScreen : UserControl
    {

        Player player;
        List<Image> runList = new List<Image>();
        List<Image> jumpList = new List<Image>();
        List<Image> landList = new List<Image>();
        List<Image> fallList = new List<Image>();
        int runCounter = 0, jumpCounter = 0, landCounter = 0, fallCounter = 0;
        bool jumping = false, landing = false, falling = false;
        public static bool inAir = true, reverseJump = false;

        List<Platform> platformList = new List<Platform>();
        int platformSpacing, spawnSpacing = 500; //change back to 175
        string currentPlatformType, nextPlatformType;
        public static int platformYChange, platformYAcceleration;
        int platformSpeed = 5;
        double unRoundedSpeed;

        Random randNum = new Random();
        public static int yVelocity;

        double difficultyScaler = 1;
        int frameCount = 0;
        int tickCount = 0;
        bool leftArrowDown, rightArrowDown, spaceDown;
        string currentDirection = null;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {
            Form1.currentScore = 0;
            Platform platform1 = new Platform(0, 155, 5, 1500, 250);
            platform1.initialY = platform1.y;
            player = new Player(240, platform1.y - playerPicture.Height, playerPicture.Width, playerPicture.Height);
            //Platform platform1 = new Platform("start", this.Height);
            platformList.Add(platform1);
            Thread.Sleep(500);
            gameTimer.Enabled = true;

            //run images (I named them backwards ): )
            runList.Add(Properties.Resources.run8);
            runList.Add(Properties.Resources.run7);
            runList.Add(Properties.Resources.run6);
            runList.Add(Properties.Resources.run5);
            runList.Add(Properties.Resources.run4);
            runList.Add(Properties.Resources.run3);
            runList.Add(Properties.Resources.run2);
            runList.Add(Properties.Resources.run1);

            //jump images
            jumpList.Add(Properties.Resources.jump1);
            jumpList.Add(Properties.Resources.jump2);
            jumpList.Add(Properties.Resources.jump3);
            jumpList.Add(Properties.Resources.jump4);
            jumpList.Add(Properties.Resources.jump5);
            jumpList.Add(Properties.Resources.jump6);
            jumpList.Add(Properties.Resources.jump7);

            //land images
            landList.Add(Properties.Resources.jump1);
            landList.Add(Properties.Resources.land1);
            landList.Add(Properties.Resources.land2);
            landList.Add(Properties.Resources.land3);

            //fall images
            fallList.Add(Properties.Resources.fall1);
            fallList.Add(Properties.Resources.fall2);
            fallList.Add(Properties.Resources.fall3);
            fallList.Add(Properties.Resources.fall4);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    gameTimer.Stop();
                    MenuScreen ms = new MenuScreen();
                    Form form = this.FindForm();

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount % 2 == 0)
            {
                Form1.currentScore++;
                scoreLabel.Text = "Score : " + Form1.currentScore + "m";
            }
            if (tickCount % 100 == 0 && platformSpeed < 10)
            {
                difficultyScaler += 0.05;
            }
            //if (player.y < 50)
            //{
            //    foreach (Platform p in platformList)
            //    {
            //        player.CameraPan(p);
            //    }
            //}
            PlayerMovement();
            #region platform movement and collision
            platformSpacing = this.Width - (platformList[platformList.Count - 1].x + platformList[platformList.Count - 1].xSize);
            if (platformSpacing > spawnSpacing)
            {
                CreatePlatform();
            }

            #region increasing platform speed
            if (tickCount % 50 == 0)
            {
                

                if (platformSpeed < 11)
                {
                    spawnSpacing = 175 + Convert.ToInt16(Math.Round(Convert.ToDouble(spawnSpacing) * (difficultyScaler / 5)));
                    platformSpeed = Convert.ToInt16(Math.Round(Convert.ToDouble(platformSpeed) * difficultyScaler));
                    
                }
                else if (platformSpeed < 20)
                {
                    spawnSpacing = 175 + Convert.ToInt16(Math.Round(Convert.ToDouble(spawnSpacing) * (difficultyScaler / 3)));
                    difficultyScaler = 1.05;
                    unRoundedSpeed = platformSpeed * difficultyScaler;
                    platformSpeed = Convert.ToInt16(Math.Round(unRoundedSpeed));
                }
                else
                {
                    spawnSpacing = 175 + Convert.ToInt16(Math.Round(Convert.ToDouble(spawnSpacing) * (difficultyScaler / 2)));
                    difficultyScaler = 1.001;
                    unRoundedSpeed = platformSpeed * difficultyScaler;
                    platformSpeed = Convert.ToInt16(Math.Round(unRoundedSpeed));
                }
                
            }
            #endregion

            foreach (Platform p in platformList)
            {
                p.Move();
                if (reverseJump == true)
                {
                    platformYChange += platformYAcceleration;
                    p.y = p.initialY + platformYChange;
                    platformYAcceleration--;

                    if (p.y <= p.initialY)
                    {
                        p.y = p.initialY;
                        reverseJump = false;
                    }

                }

                p.speed = platformSpeed;

                if (p.x + p.xSize < 0)
                {
                    platformList.Remove(p);
                    break;
                }
            }
            foreach (Platform p in platformList)
            {
                bool onPlatform = player.PlatformCollision(p);
                if (onPlatform == true)
                {
                    currentPlatformType = p.type;
                    break;
                }
            }
            #endregion
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.SandyBrown);
            //e.Graphics.FillRectangle(brush, Convert.ToInt16(player.x), Convert.ToInt16(player.y), player.width, player.height);
            foreach (Platform p in platformList)
            {
                e.Graphics.FillRectangle(brush, p.x, p.y, p.xSize, p.ySize);
            }
        }

        private void PlayerMovement()
        {
            #region player animation

            frameCount++;
            if (inAir == false && jumping == false && falling == false)
            {
                playerPicture.Width = runList[runCounter].Width;
                playerPicture.Height = runList[runCounter].Height;
                playerPicture.BackgroundImage = runList[runCounter];
                if (frameCount % 3 == 0 && frameCount != 0)
                {
                    runCounter++;
                }
                if (runCounter > 7)
                {
                    runCounter = 0;
                }
            }
            if (jumping)
            {
                playerPicture.Width = jumpList[jumpCounter].Width;
                playerPicture.Height = jumpList[jumpCounter].Height;
                playerPicture.BackgroundImage = jumpList[jumpCounter];
                if (frameCount % 5 == 0 && jumpCounter < 6)
                {
                    jumpCounter++;
                }
                if (jumpCounter == 6)
                {
                    jumpCounter = 5;
                }
                if (inAir == false)
                {
                    jumpCounter++;
                    jumping = false;
                    landing = true;
                    jumpCounter = 0;
                    frameCount = 0;
                }
            }
            if (falling)
            {
                playerPicture.Width = fallList[jumpCounter].Width;
                playerPicture.Height = fallList[fallCounter].Height;
                playerPicture.BackgroundImage = fallList[fallCounter];
                if (frameCount % 4 == 0 && fallCounter < 4)
                {
                    fallCounter++;
                }
                if (fallCounter == 4)
                {
                    fallCounter = 3;
                }
                if (inAir == false)
                {
                    fallCounter++;
                    falling = false;
                    landing = true;
                    fallCounter = 0;
                    frameCount = 0;
                }
            }
            if (landing)
            {
                playerPicture.Width = landList[landCounter].Width;
                playerPicture.Height = landList[landCounter].Height;
                playerPicture.BackgroundImage = landList[landCounter];
                if (frameCount % 4 == 0 && frameCount != 0)
                {
                    landCounter++;
                }
                if (landCounter == 4)
                {
                    runCounter = 7;
                    landing = false;
                    landCounter = 0;
                    frameCount = 0;
                }
            }

            //these two lines align the player to the bottom right corner of the picture instead of top left, which makes collision smoother with different sized frames.
            player.y += player.height - playerPicture.Height;
            player.x += player.width - playerPicture.Width;

            player.width = playerPicture.Width;
            player.height = playerPicture.Height;
            #endregion

            #region player movement
            if (spaceDown == true && inAir == false)
            {
                if (player.y > 100)
                {
                    player.jump();
                }
                else
                {
                    //player.HalfJump();
                    reverseJump = true;
                    platformYAcceleration = 15;
                    platformYChange = 0;
                }
                jumping = true;
            }
            if (inAir == true && jumping == false)
            {
                falling = true;
            }
            if (leftArrowDown && rightArrowDown == false)
            {
                currentDirection = "left";
            }
            if (rightArrowDown && leftArrowDown == false)
            {
                currentDirection = "right";
            }
            else if (!leftArrowDown && !rightArrowDown)
            {
                currentDirection = null;
            }
            player.Move(currentDirection, this.Width);
            Point picturePoint = new Point(player.x, player.y + 10); // y value is increased so that player looks like they are running on the ground, rather than hovering
            playerPicture.Location = picturePoint;
            #endregion

            #region player collision with bottom
            if (player.y > this.Height + 100)
            {
                gameTimer.Stop();
                Form form = this.FindForm();
                Highscore hs = new Highscore(null, Convert.ToString(Form1.currentScore));
                if (hs.checkHighscore(hs) == true)
                {
                    WinScreen ws = new WinScreen();
                    ws.Location = new Point((form.Width - ws.Width) / 2, (form.Height - ws.Height) / 2);

                    form.Controls.Add(ws);
                    form.Controls.Remove(this);
                }
                else
                {
                    LoseScreen ls = new LoseScreen();
                    ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);

                    form.Controls.Add(ls);
                    form.Controls.Remove(this);
                }
            }
            #endregion
        }

        private void CreatePlatform()
        {
            int num;
            if (currentPlatformType == "low" || nextPlatformType == "low")
            {
                num = randNum.Next(0, 2);
                if (num == 0)
                {
                    Platform p = new Platform("middle", this.Height);
                    nextPlatformType = "middle";
                    p.speed = platformSpeed;
                    platformList.Add(p);
                }
                else if (num == 2)
                {
                    Platform p = new Platform("low", this.Height);
                    nextPlatformType = "low";
                    p.speed = platformSpeed;
                    platformList.Add(p);
                }
            }
            else
            {
                num = randNum.Next(0, 3);
                if (num == 0)
                {
                    Platform p = new Platform("high", this.Height);
                    nextPlatformType = "high";
                    p.speed = platformSpeed;
                    platformList.Add(p);
                }
                else if (num == 1)
                {
                    Platform p = new Platform("middle", this.Height);
                    nextPlatformType = "middle";
                    p.speed = platformSpeed;
                    platformList.Add(p);
                }
                else if (num == 2)
                {
                    Platform p = new Platform("low", this.Height);
                    nextPlatformType = "low";
                    p.speed = platformSpeed;
                    platformList.Add(p);
                }
            }
        }
    }
}
