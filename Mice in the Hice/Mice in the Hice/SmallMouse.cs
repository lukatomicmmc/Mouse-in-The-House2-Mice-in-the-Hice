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
        Image[] images = new Image[9];
        public Rectangle smallmouseRec;//variable for a rectangle to place our image in
        Animation animate; // create an animation object called animate
        public int score, scorelvl, lives;
        //Create a constructor (initialises the values of the fields)
        public SmallMouse()
        {
            x = 10;
            Random ydistance = new Random();
            y = ydistance.Next(10, 435);
            width = 90;
            height = 24;
            //load the images that will make up the animated character into the images array
            for (int i = 1; i <= 8; i++)
            {
                images[i] = Image.FromFile(@"sprite_jerry" + i.ToString() + ".png");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);
        }
        // Methods for the SmallMouse class
        public void drawSmallMouse(Graphics g)
        {
            smallmouseRec = new Rectangle(x, y, width, height);
            //draw animated image
            g.DrawImage(animate.GetNextImage(), smallmouseRec);
        }
        public void moveSmallMouse()
        {
            x+=10;
            smallmouseRec.Location = new Point(x, y);
            

        }



    }
}