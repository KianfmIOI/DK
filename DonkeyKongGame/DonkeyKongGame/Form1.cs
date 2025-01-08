namespace DonkeyKongGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moving = 5;
            if (e.KeyCode == Keys.Right)
                mario.Left += moving;
            else if (e.KeyCode == Keys.Left)
                mario.Left -= moving;
            else if (e.KeyCode == Keys.Down)
                mario.Top += moving;

        }

        private void mario_Click(object sender, EventArgs e)
        {

        }

        private void ladder2_Click(object sender, EventArgs e)
        {

        }
    }
}
