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
        BigMouse[] BigMouse = new BigMouse[7];


        public FormHouse()
        {
            InitializeComponent();
        }

        private void FormHouse_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            BigMouse1.drawBigMouse(g);

        }
    }
}
