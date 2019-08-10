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
            text = deadtext.Next(1, 5);
            {
                lblDead.Text = "I'm a mouse. And you've been... MOUSED!";
                lblDead.Text = "The Mice are now in the Hice!";
                lblDead.Text = FormMenu.valueForName + " has been captured by the mice. Instead of killing you, the mice decided to make you their chef. Years pass and you become a friend to the Mice. You become one of them. 4 years later, you feel chest pain while making dinner. You know your time has come too. The mice hold a big funeral.  All of your mice friends are there to commend him. Even your cat friends are there. " + FormMenu.valueForName + " would've been happy to see this";
                lblDead.Text = "Guys, I don't want to get political or anything, but is " + FormMenu.valueForName + " dead?";
                lblDead.Text = "Don't ask who Joe is. Please don't do it. Don't ask who Joe is. Also, " + FormMenu.valueForName + " is dead.";
                lblDead.Text = "Now you can finally go back to playing Sonic Forces on your Nintendo Switch. You can make your own Sonic and play on the GO!";
                lblDead.Text = "Is it clown week again? Because what you just did is a clown move.";
                lblDead.Text = FormMenu.valueForName + " had a bruh moment.";
                lblDead.Text = FormMenu.valueForName + " needs a chug jug";
                lblDead.Text = "Ljudi, zaboravio sam engleski, upomoc! Takodje, " + FormMenu.valueForName + "je mrtav.";
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
            txtName.Text = FormMenu.valueForName;
            txtAge.Text = FormMenu.valueForAge;
            lblScore.Text = FormHouse.finalscore.ToString();
        }
    }
}
