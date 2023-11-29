using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class BreakoutGame : Form
    {
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random random = new Random();

        PictureBox[] blockArray;
        public BreakoutGame()
        {
            InitializeComponent();
            PlaceBlocks();
        }

        private void SetUpGame()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            labelTxtScore.Text = "Score: " + score;


            ball.Left = 800;
            ball.Top = 635;

            player.Left = 726;

            gameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
        }

        private void GameOver(string massage)
        {
            isGameOver = true;
            gameTimer.Stop();

            labelTxtScore.Text = "Score: " + score + " " + massage;
        }

        private void PlaceBlocks()
        {

            blockArray = new PictureBox[50];

            int a = 0;

            int top = 50;
            int left = 200;

            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;


                if (a == 10)
                {
                    top = top + 50;
                    left = 200;
                    a = 0;
                }
                if (a < 10)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                }
            }

            SetUpGame();

        }

        private void RemoveBlocks()
        {
            foreach (PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            labelTxtScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Right < 1625)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 1586)
            {
                ballx = -ballx;
            }
            if (ball.Top < 0)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {


                bally = random.Next(9, 12) * -1;

                if (ballx < 0)
                {
                    ballx = random.Next(9, 12) * -1;
                }
                else
                {
                    ballx = random.Next(9, 12);
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }
            }

            if (score == 50)
            {
                GameOver("YOU WIN !!! \n Press Enter if you want to play again \n If you want to close the game press escape ");

            }
            if (ball.Top > 1045)
            {
                GameOver("YOU LOSE !!! \n Press Enter if you want to play again\n If you want to close the game press escape");
            }

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RemoveBlocks();
                PlaceBlocks();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
