namespace DonkeyKongGame
{
    public partial class Form1 : Form
    {
        bool goRight, goLeft, closeToLadder, isJumping, isGameOver;
        int score = 0;
        int bestScore = 0;
        int marioSpeed = 5;
        int jumpSpeed = 7;
        int barrellFallSpeed = 8;
        double barrellSpeed = 3.5;
        public Form1()
        {
            InitializeComponent();
        }
        public void restartGame()
        {
            goLeft = false;
            goRight = false;
            isGameOver = false;
            if (score > bestScore)
            {
                bestScore = score;
            }
            score = 0;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox13_Click(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
