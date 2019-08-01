using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mice_in_the_Hice
{
    class Sparkles
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        Image[] images = new Image[15];
        public Rectangle sparklesRec;//variable for a rectangle to place our image in
        Animation animate; // create an animation object called animate


        //Create a constructor (initialises the values of the fields)
        public Sparkles()
        {
            x = 600;
            y = 200;
            width = 55;
            height = 30;

            //load the images that will make up the animated character into the images array
            for (int i = 1; i <= 14; i++)
            {
                images[i] = Image.FromFile(@"sprite_cat" + i.ToString() + ".png");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);

        }
        //methods
        public void drawSparkles(Graphics g)
        {
            sparklesRec = new Rectangle(x, y, width, height);
            //draw animated image
            g.DrawImage(animate.GetNextImage(), sparklesRec);
        }
        public void moveSparkles(string move)
        {
            sparklesRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (sparklesRec.Location.X > 700) // is spaceship close to right side
                {

                    x = 700;
                    sparklesRec.Location = new Point(x, y);
                }
                else
                {
                    x += 15;
                    sparklesRec.Location = new Point(x, y);
                }

            }
            if (move == "left")
            {
                if (sparklesRec.Location.X < 0) // is spaceship close to right side
                {

                    x = 0;
                    sparklesRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 15;
                    sparklesRec.Location = new Point(x, y);
                }


            }
            if (move == "down")
            {
                if (sparklesRec.Location.Y > 400) // is spaceship close to right side
                {

                    y = 400;
                    sparklesRec.Location = new Point(x, y);
                }
                else
                {
                    y += 15;
                    sparklesRec.Location = new Point(x, y);
                }

            }
            if (move == "up")
            {
                if (sparklesRec.Location.Y < 0) // is spaceship close to right side
                {

                    y = 0;
                    sparklesRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 15;
                    sparklesRec.Location = new Point(x, y);
                }

            }

        }


    }
}
