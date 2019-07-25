using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mice_in_the_Hice
{
    public partial class FormHouse : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called BigMouse 
        BigMouse[] bigmouse = new BigMouse[7];
        Random xspeed = new Random();
        SmallMouse smallmouse = new SmallMouse(); //create the object, smallmouse1


        public FormHouse()
        {
            InitializeComponent();
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



        }

        private void tmrBigMouse_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                bigmouse[i].moveBigMouse();
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void tmrSmallMouse_Tick(object sender, EventArgs e)
        {
            smallmouse.moveSmallMouse();
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}

