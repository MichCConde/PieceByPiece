using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PiecebyPiece
{
    internal class clsGame:clsMainMenu
    {
        public clsGame()
        {
            score = 0;
            playerSpeed = 7;

            horizontalSpeed = 5;
            verticalSpeed = 3;

            enemySpeed = 3;
        }

        //If player dies, must restart the game
        public override void RestartGame()
        {
            goLeft = false;
            goRight = false;
            jumping = false;
            isGameOver = false;

            score = 0;
        }

    }
}
