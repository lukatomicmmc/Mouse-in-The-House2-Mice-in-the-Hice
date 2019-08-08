using System;
using System.Windows.Forms;

namespace Mice_in_the_Hice
{
    public partial class FormMenu : Form
    {
        public static string valueForAge = "testAge";
        public static string valueForName = "testName";
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            valueForAge = btnAge.Text;
            valueForName = txtName.Text;


        FormHouse house = new FormHouse();
            this.Close();
            house.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void t_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
