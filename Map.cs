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
    public partial class Map : Form
    {
        private clsGame PBP;

        public Map()
        {
            InitializeComponent();
        }
        private void Map_Load(object sender, EventArgs e)
        {
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnSecret.Enabled = false;
            btnSecret.Visible = false;

            if (GlobalVar.Level1Achievement == true)
            {
                btnLevel2.Enabled = true;
            }

            if (GlobalVar.Level2Achievement == true)
            {
                btnLevel3.Enabled = true;
            }

            if (GlobalVar.Level1Achievement == true && GlobalVar.Level2Achievement == true && GlobalVar.Level3Achievement == true)
            {
                btnSecret.Visible = true;
                btnSecret.Enabled = true;
            }
        }

        //redirecting
        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Level1 Lvl1 = new Level1();
            Lvl1.Show();
            this.Close();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            Level2 Lvl2 = new Level2();
            Lvl2.Show();
            this.Close();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            Level3 Lvl3 = new Level3();
            Lvl3.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu Menu;
            // Check if the form is already opened
            if (Application.OpenForms.OfType<MainMenu>().Any())
            {
                Menu = Application.OpenForms.OfType<MainMenu>().First();
                // Show and bring the form to the front
                Menu.Show();
                Menu.BringToFront();
            }
            else
            {
                // If the form is not opened, create a new instance
                MainMenu Main = new MainMenu();
            }
            this.Close();
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {
            SecretLevel Lvl4 = new SecretLevel();
            Lvl4.Show();
            this.Close();
        }

        //design
        private void btnLevel1_MouseHover(object sender, EventArgs e)
        {
            btnLevel1.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons___hovered;
        }

        private void btnLevel1_MouseLeave(object sender, EventArgs e)
        {
            btnLevel1.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons;
        }

        private void btnLevel2_MouseHover(object sender, EventArgs e)
        {
            btnLevel2.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons___hovered;
        }

        private void btnLevel2_MouseLeave(object sender, EventArgs e)
        {
            btnLevel2.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons;
        }

        private void btnLevel3_MouseHover(object sender, EventArgs e)
        {
            btnLevel3.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons___hovered;
        }

        private void btnLevel3_MouseLeave(object sender, EventArgs e)
        {
            btnLevel3.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons;
        }

        private void btnL_MouseHover(object sender, EventArgs e)
        {
            btnSecret.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons___hovered;
        }

        private void btnL_MouseLeave(object sender, EventArgs e)
        {
            btnSecret.BackgroundImage = PiecebyPiece.Properties.Resources.Map_Buttons;
        }
    }
}
