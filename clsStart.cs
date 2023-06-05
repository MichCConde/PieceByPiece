using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiecebyPiece
{
    //this class is for variables that must be accessed for all, like achievements
    static class GlobalVar
    {
        private static bool lvl1Achievement = false;
        private static bool lvl2Achievement = false;
        private static bool lvl3Achievement = false;
        private static bool lvl4Achievement = false;

        public static string UUsername;
        public static string UPassword;
        public static string UCPassword;

        public static bool Level1Achievement
        {
            get { return lvl1Achievement; }
            set { lvl1Achievement = value; }
        }

        public static bool Level2Achievement
        {
            get { return lvl2Achievement; }
            set { lvl2Achievement = value; }
        }

        public static bool Level3Achievement
        {
            get { return lvl3Achievement; }
            set { lvl3Achievement = value; }
        }

        public static bool Level4Achievement
        {
            get { return lvl4Achievement; }
            set { lvl4Achievement = value; }
        }
    }
}
