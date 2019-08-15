using System;
using System.Windows.Forms;

namespace Mice_in_the_Hice
{
    public partial class FormMenu : Form
    {
        public static int finalscore;
        public static int finalscorelvl;
        public int mode;
        int age;
        public static string valueForAge = "testAge";
        public static string valueForName = "testName";
        FormHouse house = new FormHouse();
        public FormMenu()
        {
            InitializeComponent();
            valueForName = txtName.Text;
            valueForAge = btnAge.Text;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mode = 1;
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer music = new System.Media.SoundPlayer("music-looping-section.wav");
            music.PlayLooping();
            txtName.Focus();
        }

        private void btnLore_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lukatomicmmc/Mouse-in-The-House2-Mice-in-the-Hice/wiki/02.-Storyline");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lukatomicmmc/Mouse-in-The-House2-Mice-in-the-Hice/wiki/13.-Help");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13  || e.KeyChar == 32) //alpabet, backspace key
            {
                if(e.KeyChar == 13)
                {
                    btnAge.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
                txtName.Focus();
            }
        }

        private void btnAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                mode = 1;
                house.Show();
                this.Close();
            }
        }

        private void btnAge_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            mode = 2;
            FormHard hardmode = new FormHard();
            this.Close();
            hardmode.Show();

        }
    }
}
