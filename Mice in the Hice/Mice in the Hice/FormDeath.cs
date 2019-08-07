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
            FormHouse house = new FormHouse();
            this.Close();
            house.Show();
        }
    }
}
