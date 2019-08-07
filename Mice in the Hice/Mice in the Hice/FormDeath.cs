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
    public partial class FormDeath : Form
    {
        public FormDeath()
        {
            InitializeComponent();
            Random deadtext = new Random();
            int text;
            text = deadtext.Next(1, 5);
            if(text = 1)
            {
                lblDead.Text = "The Mice are in your Hice! Would you like to try again?";
            }
            if (text = 2)
            {
                lblDead.Text = "I'm a mouse. And you've been... MOUSED! Would you like to mouse again?";
            }
            if (text = 3)
            {
                lblDead.Text = "You have been caught by the mice. You ended up being their cook for the next 4 years. You've become friends with them. One day suddenly, you colapse. Your heart hurts. The old age has finally gotten to you. They hold a nice funeral for you. Your cat friends come. Even Jigglepuff, Ms Johnson's cat is there. You feel happy again, for the last time... Would you like to mouse again?";
            }
            if (text = 3)
            {
                lblDead.Text = "I'm a gnome. And you've been... GNOMED! Would you like to gnome again?";
            }
            if (text = 4)
            {
                lblDead.Text = "Guys, I don't want to get political or anything, but is Sparkles dead? Also, would you like to try again?";
            }
        }

        private void lblDead_Click(object sender, EventArgs e)
        {

        }
    }
}
