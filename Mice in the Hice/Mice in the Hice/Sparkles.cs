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
        public Image sparkles;//variable for the cat's image
        public Rectangle sparklesRec; //variable for a rectangle to place our image in


        //Create a constructor (initialises the values of the fields)
        public Sparkles()
        {
            x = 600;
            y = 200;
            width = 40;
            height = 40;
            sparkles = Image.FromFile("Sparkles1.png");
            sparklesRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawSparkles(Graphics g)
        {

            g.DrawImage(sparkles, sparklesRec);
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
