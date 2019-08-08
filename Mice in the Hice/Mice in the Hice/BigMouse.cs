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
        Image[] images = new Image[10];
        public Rectangle bigmouseRec;//variable for a rectangle to place our image in
        Animation animate; // create an animation object called animate
        public int score, scorelvl, lives;
        //Create a constructor (initialises the values of the fields)
        public BigMouse(int spacing)
        {
            y = spacing;
            width = 82;
            height = 63;


            //load the images that will make up the animated character into the images array
            for (int i = 1; i <= 9; i++)
            {
                images[i] = Image.FromFile(@"sprite_buff" + i.ToString() + ".png");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);
        }
        // Methods for the BigMouse class
        public void drawBigMouse(Graphics g)
        {
            bigmouseRec = new Rectangle(x, y, width, height);
            //draw animated image
            g.DrawImage(animate.GetNextImage(), bigmouseRec);
        }
        public void moveBigMouse()
        {

            bigmouseRec.Location = new Point(x, y);
            
        }



    }
}
