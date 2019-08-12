using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mice_in_the_Hice
{
    class Rug
    {
        public int x, y, width, height;//variables for the rectangle
        Image[] images = new Image[21];
        public Rectangle rugRec;//variable for a rectangle to place our image in
        Animation animate; // create an animation object called animate
        //Create a constructor (initialises the values of the fields)
        public Rug()
        {
            x = 0;
            y = 0;
            width = 960;
            height = 553;
            //load the images that will make up the animated character into the images array
            for (int i = 1; i <= 20; i++)
            {
                images[i] = Image.FromFile(@"sprite_floor" + i.ToString() + ".png");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);
            // Methods for the Rug class
        }
            public void drawRug(Graphics g)
            {
                rugRec = new Rectangle(x, y, width, height);
                //draw animated image
                g.DrawImage(animate.GetNextImage(), rugRec);
            }
        }
    }

