using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiecebyPiece
{
    public partial class MainMenu : Form
    {
        clsGame PBP = new clsGame();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //hide panel
            pnlRegister.Visible = false;
            pnlLogin.Visible = false;


            //Hide achievements
            pbAchievement1.Visible = false;
            pbAchievement2.Visible = false;
            pbAchievement3.Visible = false;
            pbAchievement4.Visible = false;

            //show acievements
            if (GlobalVar.Level1Achievement == true)
            {
                pbAchievement1.Visible = true;
            }
            if (GlobalVar.Level2Achievement == true)
            {
                pbAchievement2.Visible = true;
            }
            if (GlobalVar.Level3Achievement == true)
            {
                pbAchievement3.Visible = true;
            }
            if (GlobalVar.Level4Achievement == true)
            {
                pbAchievement4.Visible = true;
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            PBP.Username = GlobalVar.UUsername;

            if (GlobalVar.UUsername == null)
            {
                pnlRegister.Visible = true;
                pnlLogin.Visible = false;
            }
            else
            {
                pnlRegister.Visible = false;
                pnlLogin.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GlobalVar.UUsername = txtUUsername.Text;
            GlobalVar.UPassword = txtUPassword.Text;
            GlobalVar.UCPassword = txtUCPassword.Text;

            if (GlobalVar.UPassword.Length > 8)
            {
                if (GlobalVar.UPassword != GlobalVar.UCPassword)
                {
                    txtUPassword.Clear();
                    txtUCPassword.Clear();

                    MessageBox.Show("Password does not match!");
                }
                else
                {
                    MessageBox.Show("You are now registered.");
                    pnlRegister.Visible = false;
                    pnlLogin.Visible = true;
                }
            }
            else
            {
                txtUPassword.Clear();
                txtUCPassword.Clear();

                MessageBox.Show("Password is weak!");
            }

            pbAchievement1.Visible = false;
            pbAchievement2.Visible = false;
            pbAchievement3.Visible = false;
            pbAchievement4.Visible = false;
            GlobalVar.Level1Achievement = false;
            GlobalVar.Level2Achievement = false;
            GlobalVar.Level3Achievement = false;
            GlobalVar.Level4Achievement = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PBP.Username = txtUsername.Text;
            PBP.Password = txtPassword.Text;

            if (PBP.Username != GlobalVar.UUsername || PBP.Password != GlobalVar.UPassword)
            {
                txtUPassword.Clear();
                txtUCPassword.Clear();
                MessageBox.Show("Username or Password is invalid!");
            }
            else
            {
                pnlRegister.Visible = false;
                pnlLogin.Visible = false;

                Map map = new Map();
                map.Show();
                this.Hide();
            }
        }
        private void btnRegisterPNL_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlRegister.BringToFront();

            pnlLogin.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit all
            Environment.Exit(0);
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();

            pnlRegister.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
