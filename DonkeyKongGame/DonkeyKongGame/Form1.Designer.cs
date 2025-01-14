namespace DonkeyKongGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            platformEnd = new PictureBox();
            ladder3 = new PictureBox();
            ladder1 = new PictureBox();
            ladder2 = new PictureBox();
            mario = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)platformEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ladder3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ladder1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ladder2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 64, 64);
            pictureBox1.Location = new Point(180, 432);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(551, 19);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 64, 64);
            pictureBox2.Location = new Point(100, 312);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(535, 19);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(128, 64, 64);
            pictureBox3.Location = new Point(188, 188);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(605, 19);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // platformEnd
            // 
            platformEnd.BackColor = Color.FromArgb(128, 64, 64);
            platformEnd.Location = new Point(229, 94);
            platformEnd.Margin = new Padding(3, 2, 3, 2);
            platformEnd.Name = "platformEnd";
            platformEnd.Size = new Size(449, 19);
            platformEnd.TabIndex = 0;
            platformEnd.TabStop = false;
            platformEnd.Click += pictureBox2_Click;
            // 
            // ladder3
            // 
            ladder3.BackColor = Color.Yellow;
            ladder3.Location = new Point(595, 94);
            ladder3.Margin = new Padding(3, 2, 3, 2);
            ladder3.Name = "ladder3";
            ladder3.Size = new Size(25, 113);
            ladder3.TabIndex = 1;
            ladder3.TabStop = false;
            // 
            // ladder1
            // 
            ladder1.BackColor = Color.Yellow;
            ladder1.Location = new Point(514, 312);
            ladder1.Margin = new Padding(3, 2, 3, 2);
            ladder1.Name = "ladder1";
            ladder1.Size = new Size(21, 137);
            ladder1.SizeMode = PictureBoxSizeMode.StretchImage;
            ladder1.TabIndex = 1;
            ladder1.TabStop = false;
            // 
            // ladder2
            // 
            ladder2.BackColor = Color.FromArgb(255, 255, 128);
            ladder2.Location = new Point(289, 188);
            ladder2.Margin = new Padding(3, 2, 3, 2);
            ladder2.Name = "ladder2";
            ladder2.Size = new Size(24, 143);
            ladder2.TabIndex = 2;
            ladder2.TabStop = false;
            ladder2.Click += ladder2_Click;
            // 
            // mario
            // 
            mario.BackColor = Color.Blue;
            mario.Location = new Point(196, 402);
            mario.Margin = new Padding(3, 2, 3, 2);
            mario.Name = "mario";
            mario.Size = new Size(22, 26);
            mario.TabIndex = 3;
            mario.TabStop = false;
            mario.Click += mario_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Yellow;
            pictureBox4.Location = new Point(424, 30);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 83);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(128, 64, 64);
            pictureBox5.Location = new Point(333, 30);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(136, 19);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(893, 462);
            Controls.Add(pictureBox5);
            Controls.Add(platformEnd);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(mario);
            Controls.Add(ladder2);
            Controls.Add(ladder1);
            Controls.Add(pictureBox4);
            Controls.Add(ladder3);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "DK";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)platformEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)ladder3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ladder1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ladder2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox platformEnd;
        private PictureBox ladder3;
        private PictureBox ladder1;
        private PictureBox ladder2;
        private PictureBox mario;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
