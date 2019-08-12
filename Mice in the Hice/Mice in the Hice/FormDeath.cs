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
        FormHouse house = new FormHouse();

        public FormDeath()
        {
            InitializeComponent();
            Random deadtext = new Random();
            int text;
            text = deadtext.Next(1, 9);
            {
                if (text > 0)
                {
                    lblDead.Text = "I'm a mouse. And you've been... MOUSED!";
                }
                if (text > 1)
                {
                    lblDead.Text = "The Mice are now in the Hice!";
                }
                if (text > 2)
                {
                    lblDead.Text = "Ljudi, zaboravio sam engleski, upomoc! Takodje, " + FormMenu.valueForName + " je mrtav.";
                }
                if (text > 3)
                {
                    lblDead.Text = "Guys, I don't want to get political or anything, but is " + FormMenu.valueForName + " dead?";
                }
                if (text > 4)
                {
                    lblDead.Text = "Don't ask who Joe is. Please don't do it. Don't ask who Joe is. Also, " + FormMenu.valueForName + " is dead.";
                }
                if (text > 5)
                {
                    lblDead.Text = "Now you can finally go back to playing Sonic Forces on your Nintendo Switch. You can make your own Sonic and play on the GO!";
                }
                if (text > 6)
                {
                    lblDead.Text = "Is it clown week again? Because what you just did is a clown move.";
                }
                if (text > 7)
                {
                    lblDead.Text = FormMenu.valueForName + " had a bruh moment.";
                }
                if (text > 8)
                {
                    lblDead.Text = FormMenu.valueForName + " needs a chug jug.";
                }
            }

        }

        private void lblDead_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Close();
            menu.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Close();
            house.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDeath_Load(object sender, EventArgs e)
        {
            lblName.Text = FormMenu.valueForName;
            lblAge.Text = FormMenu.valueForAge;
            lblScore.Text = FormHouse.finalscore.ToString();
            lblScoreLvl.Text = FormHouse.finalscorelvl.ToString();
        }
    }
}
