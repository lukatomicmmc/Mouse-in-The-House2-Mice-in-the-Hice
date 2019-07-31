using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Mice_in_the_Hice
{
    class SmallMouse
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image smallmouseImage;//variable for the smallmouse's image
        public Rectangle smallmouseRec;//variable for a rectangle to place our image in
        public int score, scorelvl, lives;
        //Create a constructor (initialises the values of the fields)
        public SmallMouse()
        {
            x = 10;
            Random ydistance = new Random();
            y = ydistance.Next(10, 435);
            width = 20;
            height = 20;
            smallmouseImage = Image.FromFile("BigMouse1.png");
            smallmouseRec = new Rectangle(x, y, width, height);
        }
        // Methods for the SmallMouse class
        public void drawSmallMouse(Graphics g)
        {
            smallmouseRec = new Rectangle(x, y, width, height);
            g.DrawImage(smallmouseImage, smallmouseRec);
        }
        public void moveSmallMouse()
        {
            x+=10;
            smallmouseRec.Location = new Point(x, y);
            

        }



    }
}