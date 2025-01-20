using System.Security.Permissions;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DonkeyKongGame
{
    public partial class Form1 : Form
    {
        List<barrells> barrellsList = new List<barrells>();

        bool goRight, goLeft, goUp, goDown, isJumping, isGameOver, isClimbing, onGround, isOnLadder;
        int score = 0;
        int bestScore = 0;
        int marioSpeed = 7;
        int marioClimb = 4;
        int jumpSpeed = 10;
        int force = 0;
        double time = 60.0;
        int formHeight = 810;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void mainGameTime(object sender, EventArgs e)
        {
            counter++;
            if (counter % 60 == 0)
            {
                barrells newBarrel = new barrells(this);
                barrellsList.Add(newBarrel);
            }
            foreach (var barrel in barrellsList)
            {
                barrel.movement();
                barrel.falling();
                if (barrel.marioCollide(mario))
                {
                    gameTimer.Stop();
                    isGameOver = true;
                    ScoreTXT.Text = ($"GAME\nscore: {score}\nbest score: {bestScore}");

                }
                if (barrel.inTheAbyss())
                    barrellsList.Remove(barrel);
            }
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
        private void removeBarrels()
        {
            foreach (var barrels in barrellsList.ToArray())
            {
                this.Controls.Remove(barrels.Barrells);
                barrels.Barrells.Dispose();

            }
            barrellsList.Clear();
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
            removeBarrels();
            time = 60;
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
            label1.Text = "best score: " + bestScore;
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
        class barrells
        {
            Form main_form;
            BadImageFormatException badImageFormatException;
            bool movement_right = true;
            PictureBox barrels = new PictureBox();

            public barrells(Form main_form,int BarrelX = 450,int BarrelY = 10)
            {
                Barrells = new PictureBox();

                Barrells.BackColor = Color.DarkSalmon;
                Barrells.Size = new System.Drawing.Size(12, 12);
                Barrells.Location = new System.Drawing.Point(BarrelX, BarrelY);
                Barrells.Tag = "Barrell";
                this.main_form = main_form;

                // Add it to the form controls
                main_form.Controls.Add(Barrells);

            }
            public PictureBox Barrells { get; private set; }

            public void movement()
            {
                if (Barrells.Location.X < 0 && movement_right == false)
                {
                    movement_right = true;
                }
                else if (Barrells.Location.X > 524 && movement_right)
                {
                    movement_right = false;
                }

                if (movement_right)
                {
                    Barrells.Location = new System.Drawing.Point(Barrells.Location.X + 2, Barrells.Location.Y);
                }
                else
                {
                    Barrells.Location = new System.Drawing.Point(Barrells.Location.X - 2, Barrells.Location.Y);
                }
            }
            public void falling()
            {
                foreach (Control x in main_form.Controls)
                {
                    if (x is PictureBox)
                        if ((string)x.Tag == "Ground")
                            if (Barrells.Bounds.IntersectsWith(x.Bounds))
                            {
                                if ((Barrells.Left <= x.Left || Barrells.Right >= x.Right) && Barrells.Right < main_form.Width-20)
                                {
                                    Barrells.Location = new System.Drawing.Point(Barrells.Location.X+10, Barrells.Location.Y+100);
                                }
                                break;
                            }

                }
            }
            public bool marioCollide(PictureBox mario)
            {
                return (Barrells.Bounds.IntersectsWith(mario.Bounds));
            }
            public bool inTheAbyss()
            {
                return (Barrells.Location.Y > 620);
            }

        }
    }

}
