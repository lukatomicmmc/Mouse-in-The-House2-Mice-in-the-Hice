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
        int x, y, width, height;//variables for the rectangle
        public Image BigMouseImage;//variable for the planet's image

        public Rectangle BigMouseRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public BigMouse()
        {
            x = 10;
            y = 10;
            width = 40;
            height = 40;
            BigMouseImage = Image.FromFile("BigMouse1.png");
            BigMouseRec = new Rectangle(x, y, width, height);
        }
        // Methods for the BigMouse class
        public void drawBigMouse(Graphics g)
        {
            g.DrawImage(BigMouseImage, BigMouseRec);
        }


    }
}
