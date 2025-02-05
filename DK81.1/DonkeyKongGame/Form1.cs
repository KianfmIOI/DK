using System.Security.Permissions;

namespace DonkeyKongGame
{
    public partial class Form1 : Form
    {
        bool goRight, goLeft, goUp, goDown, isJumping, isGameOver, isClimbing, onGround, isOnLadder;
        int score = 0;
        int bestScore = 0;
        int marioSpeed = 7;
        int Bar1S=2, Bar2S = 2, Bar3S = 2, Bar4S = 2, Bar5S = 2, Bar6S = 2, Bar7S = 2;
        int marioClimb = 4;
        int jumpSpeed = 10;
        int barrellGravity = 10;
        int force = 0;
        double time = 60.0;
        int formHeight = 560;
        int barrelX = 495, barrelY = 37;
        public Form1()
        {
            InitializeComponent();
        }
        private void mainGameTime(object sender, EventArgs e)
        {
            TIMELable.Text = "0:" + (int)time;
            time -= 0.03;
            ScoreTXT.Text = "score: " + score;
            label1.Text = "best score: " + bestScore;
            if (isOnLadder && (goUp || goDown))
            {
                isClimbing = true;
                onGround = false;
                jumpSpeed = 0;

                if (goUp)
                    mario.Top -= marioClimb;
                if (goDown)
                    mario.Top += marioClimb;
            }
            else
            {
                isClimbing = false;
            }
            if (goLeft)
                mario.Left -= marioSpeed;

            if (goRight)
                mario.Left += marioSpeed;

            if (!isClimbing)
            {
                if (isJumping && force < 0)
                {
                    isJumping = false;
                }
                if (isJumping)
                {

                    jumpSpeed = -8;
                    force--;
                }
                else
                    jumpSpeed = 10;
                mario.Top += jumpSpeed;
            }
            Bar1.Left += Bar1S;
            Bar2.Left += Bar2S;
            Bar3.Left += Bar3S;
            Bar4.Left += Bar4S;
            Bar5.Left += Bar5S;
            Bar6.Left += Bar6S;
            Bar7.Left += Bar7S;

            Bar1.Top += barrellGravity;
            Bar2.Top += barrellGravity;
            Bar3.Top += barrellGravity;
            Bar4.Top += barrellGravity;
            Bar5.Top += barrellGravity;
            Bar6.Top += barrellGravity;
            Bar7.Top += barrellGravity;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Ground")
                    {
                        if (mario.Bounds.IntersectsWith(x.Bounds) && !isJumping && !isClimbing)
                        {
                            mario.Top = x.Top - mario.Height;
                            onGround = true;
                            force = 5;
                        }
                        if (Bar1.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar1.Top = x.Top - Bar1.Height;
                            int edgeOffset = 2;
                            if (Bar1.Left <= x.Left - edgeOffset || Bar1.Right >= x.Right + edgeOffset)
                            {
                                Bar1S = -Bar1S;

                            }
                        }
                        if (Bar2.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar2.Top = x.Top - Bar2.Height;
                            int edgeOffset = 2;
                            if (Bar2.Left <= x.Left - edgeOffset || Bar2.Right >= x.Right + edgeOffset)
                            {
                                Bar2S = -Bar2S;

                            }
                        }
                        if (Bar3.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar3.Top = x.Top - Bar3.Height;
                            int edgeOffset = 2;
                            if (Bar3.Left <= x.Left - edgeOffset || Bar3.Right >= x.Right + edgeOffset)
                            {
                                Bar3S = -Bar3S;

                            }
                        }
                        if (Bar4.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar4.Top = x.Top - Bar4.Height;
                            int edgeOffset = 2;
                            if (Bar4.Left <= x.Left - edgeOffset || Bar4.Right >= x.Right + edgeOffset)
                            {
                                Bar4S = -Bar4S;

                            }
                        }
                        if (Bar5.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar5.Top = x.Top - Bar5.Height;
                            int edgeOffset = 2;
                            if (Bar5.Left <= x.Left - edgeOffset || Bar5.Right >= x.Right + edgeOffset)
                            {
                                Bar5S = -Bar5S;

                            }
                        }
                        if (Bar6.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar6.Top = x.Top - Bar6.Height;
                            int edgeOffset = 2;
                            if (Bar6.Left <= x.Left - edgeOffset || Bar6.Right >= x.Right + edgeOffset)
                            {
                                Bar6S = -Bar6S;

                            }
                        }
                        if (Bar7.Bounds.IntersectsWith(x.Bounds))
                        {
                            Bar7.Top = x.Top - Bar7.Height;
                            int edgeOffset = 2;
                            if (Bar7.Left <= x.Left - edgeOffset || Bar7.Right >= x.Right + edgeOffset)
                            {
                                Bar7S = -Bar7S;

                            }
                        }


                        x.BringToFront();
                    }
                    if ((string)x.Tag == "Ladder")
                    {
                        if (mario.Bounds.IntersectsWith(x.Bounds))
                        {
                            isOnLadder = true;
                            break;
                        }
                        else
                        {
                            isOnLadder = false;
                        }
                    }
                    if ((string)x.Tag == "coin" && x.Visible)
                    {
                        if (mario.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    if ((string)x.Tag == "Barrell")
                    {
                        if (mario.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            ScoreTXT.Text = ($"GAME\nscore: {score}\nbest score: {bestScore}");
                            
                        }

                    }
                }
            }
            if (mario.Bounds.IntersectsWith(Princess.Bounds))
            {
                gameTimer.Stop();
                isGameOver = true;
                ScoreTXT.Text = ($"you won!!!\nscore: {score}\nbest score: {bestScore}");

            }
            if (mario.Top > formHeight)
            {
                gameTimer.Stop();
                isGameOver = true;
                ScoreTXT.Text = ($"GAME\nyou fell \nand so you fail\nscore: {score}\nbest score: {bestScore}");

            }
            if (time <= 0)
            {
                gameTimer.Stop();
                isGameOver = true;
                ScoreTXT.Text = ($"GAME\nscore: {score}\nbest score: {bestScore}");

            }

        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.S) goDown = true;
            if (e.KeyCode == Keys.D) goRight = true;

            if (e.KeyCode == Keys.E && !isJumping && onGround)
            {
                force = 5;
                isJumping = true;
                onGround = false;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) goUp = false;
            if (e.KeyCode == Keys.A) goLeft = false;
            if (e.KeyCode == Keys.S) goDown = false;
            if (e.KeyCode == Keys.D) goRight = false;
            if (isJumping) isJumping = false;

            if (e.KeyCode == Keys.Enter)
                restartGame();
        }
        public void restartGame()
        {
            time = 60;
            Bar7.Left = 580;
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            if (score > bestScore)
            {
                bestScore = score;
            }
            score = 0;
            TIMELable.Text = "0:" + (int)time;
            ScoreTXT.Text = "score: " + score;
            label1.Text = "best score: "+ bestScore;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
            mario.Top = 448;
            mario.Left = 169;
            gameTimer.Start();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //private void barrelMakerTimer(object sender, EventArgs e)
        //{
        //    PictureBox pictureBox = new PictureBox
        //    {
        //        Width = 12, 
        //        Height = 12,
        //        Location = new Point(barrelX, barrelY),
        //        BackColor = Color.DarkSalmon,
        //        Tag = "Barrell"
        //    };
        //    this.Controls.Add(pictureBox);

        //}
    }
}
