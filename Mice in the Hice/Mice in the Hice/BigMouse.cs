using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Mice_in_the_Hice
{
    class BigMouse
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image bigmouseImage;//variable for the bigmouse's image
        public Rectangle bigmouseRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public BigMouse(int spacing)
        {
            x = 10;
            y = spacing;
            width = 35;
            height = 35;
            bigmouseImage = Image.FromFile("BigMouse1.png");
            bigmouseRec = new Rectangle(x, y, width, height);
        }
        // Methods for the BigMouse class
        public void drawBigMouse(Graphics g)
        {
            bigmouseRec = new Rectangle(x, y, width, height);
            g.DrawImage(bigmouseImage, bigmouseRec);
        }
        public void moveBigMouse()
        {

            bigmouseRec.Location = new Point(x, y);
            if (bigmouseRec.Location.X > 750)
            {
                x = -20;
                bigmouseRec.Location = new Point(x, y);
            }

        }



    }
}
