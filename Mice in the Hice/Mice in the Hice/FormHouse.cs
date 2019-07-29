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
    public partial class FormHouse : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called BigMouse 
        BigMouse[] bigmouse = new BigMouse[7];
        Sparkles sparkles = new Sparkles();
        Random xspeed = new Random();
        SmallMouse smallmouse = new SmallMouse(); //create the object, smallmouse1
        bool left, right, up, down;
        string move;


        public FormHouse()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 75);
                bigmouse[i] = new BigMouse(y);
            }

        }



        private void FormHouse_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 20);
                bigmouse[i].x += rndmspeed;

                //call the BigMouse class's drawBigMouse method to draw the images
                bigmouse[i].drawBigMouse(g);
            }
            //call the SmallMouse class's DrawSmallMouse method to draw the image smallmouse1 
            smallmouse.drawSmallMouse(g);
            sparkles.drawSparkles(g);


        }

        private void tmrBigMouse_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                bigmouse[i].moveBigMouse();
            }
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
            smallmouse.moveSmallMouse();
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void FormHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

        }

        private void FormHouse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }

        }
    }
}

