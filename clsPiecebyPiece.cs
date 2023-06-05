using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiecebyPiece
{
    abstract class clsMainMenu
    {
        //Register and Login
        public string Username;
        public string Password;

        //player attributes
        public int jumpSpeed;
        public int force;
        public int score;
        public int playerSpeed;

        //movement
        public bool goLeft;
        public bool goRight;
        public bool jumping;
        public bool isGameOver;

        //platform
        public int horizontalSpeed;
        public int verticalSpeed;

        //enemy
        public int enemySpeed;

        //function
        public abstract void RestartGame();
    }
}
