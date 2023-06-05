using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiecebyPiece
{
    public partial class SecretLevel : Form
    {
        clsGame PBP = new clsGame();
        public SecretLevel()
        {
            InitializeComponent();
        }

        private void SecretLevel_Load(object sender, EventArgs e)
        {
            pnlComplete.Visible = false;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //player movements
            if (e.KeyCode == Keys.Left)
            {
                PBP.goLeft = true;
                //changes the character image
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Movement;
                Player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Right)
            {
                PBP.goRight = true;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Movement;
            }
            if (e.KeyCode == Keys.Space && PBP.jumping == false)
            {
                PBP.jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //if player stops pressing the keys, the movement stops
            if (e.KeyCode == Keys.Left)
            {
                PBP.goLeft = false;
                //changes the character image
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Idle;
                Player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Right)
            {
                PBP.goRight = false;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Idle;
            }
            if (PBP.jumping == true)
            {
                PBP.jumping = false;
            }

            if (e.KeyCode == Keys.Enter && PBP.isGameOver == true)
            {
                RestartGame();
            }
        }

        private void SecretLevelTimer(object sender, EventArgs e)
        {
            //door is not visible if all the pieces arent collected
            Door.Visible = false;

            txtScore.Text = "Pieces Collected: " + PBP.score;

            Player.Top += PBP.jumpSpeed;

            if (PBP.goLeft == true)
            {
                Player.Left -= PBP.playerSpeed;
            }
            if (PBP.goRight == true)
            {
                Player.Left += PBP.playerSpeed;
            }

            //jumping mechanics, forces = how high the jump is
            if (PBP.jumping == true && PBP.force < 0)
            {
                PBP.jumping = false;
            }
            if (PBP.jumping == true)
            {
                PBP.jumpSpeed = -8;
                PBP.force -= 1;
            }
            else
            {
                PBP.jumpSpeed = 10;
            }

            //moves the platform up and down
            verticalPlatform.Top += PBP.verticalSpeed;
            if (verticalPlatform.Top < 110 || verticalPlatform.Top > 300)
            {
                PBP.verticalSpeed = -PBP.verticalSpeed;
            }

            //moves the player on top of the platform if it touches the platform
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Platform")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            PBP.force = 8;
                            Player.Top = x.Top - Player.Height;

                            //player doesnt move if on the platform
                            if ((string)x.Name == "horizontalPlatform" && PBP.goLeft == false || (string)x.Name == "horizontalPlatform" && PBP.goRight == false)
                            {
                                Player.Left += PBP.horizontalSpeed;
                            }

                        }

                        //platform design will be infront
                        x.BringToFront();
                    }

                    //player collecting coins
                    if ((string)x.Tag == "Piece")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            PBP.score++;
                        }
                    }

                    //player gets killed with mob
                    if ((string)x.Tag == "Enemy")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            GameTimer.Stop();
                            PBP.isGameOver = true;
                            MessageBox.Show("You Died! \nTry Again.");
                        }
                    }
                }
            }

            //enemy movement
            Enemy2.Left += PBP.enemySpeed;
            if (Enemy2.Left < Platform2.Left || Enemy2.Left + Enemy2.Width > Platform2.Left + Platform2.Width)
            {
                PBP.enemySpeed = -PBP.enemySpeed;
                Enemy2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            Enemy1.Left += PBP.enemySpeed;
            if (Enemy1.Left < Platform.Left || Enemy1.Left + Enemy1.Width > Platform.Left + Platform.Width)
            {
                PBP.enemySpeed = -PBP.enemySpeed;
                Enemy1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            //if player falls off map
            if (Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                PBP.isGameOver = true;
                MessageBox.Show("You fell and Died! \n Try Again.");
            }

            //door only appears if score is 3
            if (PBP.score == 3)
            {
                Door.Visible = true;
            }

            //if player reaches the door
            if (Player.Bounds.IntersectsWith(Door.Bounds) && PBP.score == 3)
            {
                GameTimer.Stop();
                PBP.isGameOver = true;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Idle;

                pnlComplete.Visible = true;
                pnlComplete.BringToFront();

                //Add achievement
                GlobalVar.Level4Achievement = true;
            }
        }

        private void RestartGame()
        {
            PBP.RestartGame();

            txtScore.Text = "Pieces Collected: " + PBP.score;

            //restarting the score and making the pieces visible again
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //reset positions of all the sprites
            Player.Left = 30;
            Player.Top = 330;

            verticalPlatform.Top = 300;

            Enemy1.Left = 710;

            Enemy2.Left = 350;
            //Restarting the timer
            GameTimer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            form.BringToFront();
            this.Close();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
            map.BringToFront();
            this.Close();
        }
    }
}
