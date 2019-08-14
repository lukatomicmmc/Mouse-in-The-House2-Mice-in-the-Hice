using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Mice_in_the_Hice
{
    public partial class FormHard : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called BigMouse 
        BigMouse[] bigmouse = new BigMouse[6];
        Sparkles sparkles = new Sparkles();
        SmallMouse smallmouse = new SmallMouse();
        Rug rug = new Rug();
        Random xspeed = new Random();
        bool left, right, up, down;
        string move;
        public static int finalscore;
        public static int finalscorelvl;
        public int score, speed;
        int x, y;
        //images array for animating
        Image[] images = new Image[15];
        Animation animate;
        int death;
        int pause;


        public FormHard()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 6; i++)
            {
                int y = 0 + (i * 100);
                bigmouse[i] = new BigMouse(y);
            }
            

        }


        private void checkLives()
        {
            if (lives == 0)
            {
                finalscore = score;
                finalscorelvl = scorelvl;
                tmrMice.Enabled = false;
                tmrSparkles.Enabled = false;
                tmrAnim.Enabled = false;
                FormDeath death = new FormDeath();
                this.Close();
                death.Show();
            }
        }


        private void FormHard_Load(object sender, EventArgs e)
        {
            pause = 1;
            death = 0;

            txtName.Text = FormMenu.valueForName;
            txtAge.Text = FormMenu.valueForAge;

        }

        

        private void tmrAnim_Tick(object sender, EventArgs e)
        {


        }
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            rug.drawRug(g);
            for (int i = 0; i < 6; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 25);
                speed = rndmspeed + 2 * scorelvl;
                bigmouse[i].x += speed;

                //call the BigMouse class's drawBigMouse method to draw the images
                bigmouse[i].drawBigMouse(g);
            }
            sparkles.drawSparkles(g);
            //call the SmallMouse class's DrawSmallMouse method to draw the image smallmouse1 
            smallmouse.drawSmallMouse(g);
            sparkles.drawSparkles(g);

        }

        private void lblPause_Click(object sender, EventArgs e)
        {

        }

        private void lblRetry_Click(object sender, EventArgs e)
        {
            FormHard retry = new FormHard();
            retry.Show();
            this.Close();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void FormHard_Load_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tmrBigMouse_Tick(object sender, EventArgs e)
        {
            
        }

        private void tmrMice_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                bigmouse[i].moveBigMouse();
                if (bigmouse[i].bigmouseRec.Location.X > 1000)
                {
                    score += 1;
                    bigmouse[i].x = -50;
                }
                if (sparkles.sparklesRec.IntersectsWith(bigmouse[i].bigmouseRec))
                {
                    //reset bigmouse[i] back to left of panel
                    bigmouse[i].x = -50; // set  x value of bigmouseRec
                    lives -= 1;// lose a life
                    lblLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }

                score += bigmouse[i].score;// get score from BigMouse class (in moveBigMouse method)

            }
            if (sparkles.sparklesRec.IntersectsWith(smallmouse.smallmouseRec))
            {
                //reset smallmouse back to left of panel
                Random ydistance = new Random();
                smallmouse.y = ydistance.Next(50, 450);
                smallmouse.x = -20;
                score += 1;// increase score
            }
            if (smallmouse.smallmouseRec.Location.X > 1000)
            {
                lives -= 1;
                smallmouse.x = -20;
                Random ydistance = new Random();
                smallmouse.y = ydistance.Next(50, 450);
                checkLives();
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
            lblLives.Text = lives.ToString();
            if (score > scorelvl * scorelvl)
            {
                scorelvl += 1;
                lives += 1;
            }
            lblScoreLvl.Text = scorelvl.ToString();
            smallmouse.moveSmallMouse();
            lblScore.Text = score.ToString();// display score
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void tmrSparkles_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                sparkles.moveSparkles(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                sparkles.moveSparkles(move);
            }

            if (up) // if right arrow key pressed
            {
                move = "up";
                sparkles.moveSparkles(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                sparkles.moveSparkles(move);
            }

        }

        private void tmrSmallMouse_Tick(object sender, EventArgs e)
        {
            
        }

        private void FormHard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
            if (e.KeyData == Keys.Escape)
            {
                if (pause > 0)
                {
                    tmrMiced.Enabled = false;
                    tmrSparkled.Enabled = false;
                    tmrAnimed.Enabled = false;
                    lblPaused.Text = "PAUSED";
                    pause -= 1;
                    lblRetried.Text = "Retry";
                    lblRetried.BackColor = Color.DarkGray;
                    lblMenud.Text = "Main Menu";
                    lblMenud.BackColor = Color.DarkGray;
                    lblRetried.BorderStyle = BorderStyle.Fixed3D;
                    lblMenud.BorderStyle = BorderStyle.Fixed3D;
                    lblRetried.Cursor = Cursors.Hand;
                    lblMenud.Cursor = Cursors.Hand;
                } else
                {
                    pause += 1;
                    tmrMiced.Enabled = true;
                    tmrSparkled.Enabled = true;
                    tmrAnimed.Enabled = true;
                    lblPaused.Text = "";
                    lblRetried.Text = "";
                    lblRetried.BackColor = Color.Transparent;
                    lblMenud.Text = "";
                    lblMenud.BackColor = Color.Transparent;
                    lblRetried.BorderStyle = BorderStyle.None;
                    lblMenud.BorderStyle = BorderStyle.None;
                    lblRetried.Cursor = Cursors.Default;
                    lblMenud.Cursor = Cursors.Default;
                }
            }
        }

        private void FormHard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }

        }
    }
}

