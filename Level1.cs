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
    public partial class Level1 : Form
    {
        clsGame PBP = new clsGame();
        public Level1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            //door is not visible if all the pieces arent collected
            Door.Visible = false;

            //meaning the player moved
            if(PBP.score == 1)
            {
                lblGuide1.Visible = false;
                lblGuide3.Visible = false;
                lblGuide2.Visible = true;
            }
            else
            {
                lblGuide2.Visible = false;
                lblGuide3.Visible = false;
            }

            txtScore.Text = "Pieces Collected: " + PBP.score;

            //jumping mechanics, forces = how high the jump is
            Player.Top += PBP.jumpSpeed;

            if (PBP.goLeft == true)
            {
                Player.Left -= PBP.playerSpeed;
            }
            if (PBP.goRight == true)
            {
                Player.Left += PBP.playerSpeed;
            }

            if(PBP.jumping == true && PBP.force < 0)
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

            //moves the player on top of the platform if it touches the platform
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Platform")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            PBP.force = 8;
                            Player.Top = x.Top - Player.Height;
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
                }
            }
            //if player falls off map
            if (Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                PBP.isGameOver = true;
                MessageBox.Show("You fell and Died! \nTry Again.");
            }

            //door only appears if score is 3
            if(PBP.score == 3)
            {
                Door.Visible = true;
                lblGuide2.Visible = false;
                lblGuide3.Visible = true;
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
                GlobalVar.Level1Achievement = true;
            }
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            //Guides not visible at the start (for effect)
            lblGuide2.Visible = false;
            lblGuide3.Visible = false;
            pnlComplete.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            Level2 Form = new Level2();
            Form.Show();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            form.BringToFront();
            this.Close();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //player movements
            if (e.KeyCode == Keys.Left)
            {
                PBP.goLeft = true;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Movement;
                Player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if(e.KeyCode == Keys.Right)
            {
                PBP.goRight = true;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Movement;
            }
            if(e.KeyCode == Keys.Space && PBP.jumping == false)
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
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Idle;
                Player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Right)
            {
                PBP.goRight = false;
                Player.Image = PiecebyPiece.Properties.Resources.Sprite_Idle;
            }
            if(PBP.jumping == true)
            {
                PBP.jumping = false;
            }

            if(e.KeyCode == Keys.Enter && PBP.isGameOver == true)
            {
                RestartGame();
            }
        }

        //if player dies or game must restart
        private void RestartGame()
        { 
            PBP.RestartGame();

            txtScore.Text = "Pieces Collected: " + PBP.score;

            //restarting the score and making the pieces visible again
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //reset positions of all the sprites
            Player.Left = 30;
            Player.Top = 330;

            //Restarting the timer
            GameTimer.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
