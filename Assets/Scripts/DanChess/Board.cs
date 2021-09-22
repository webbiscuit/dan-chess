using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChess
{
    public class Board
    {
        public const int Ranks = 8;
        public const int Files = 8;

        private const string fileNames = "abcdefgh";
        private const string rankNames = "12345678";

        public static string GetSquareName(int file, int rank)
        {
            return fileNames[file] + "" + (rank + 1);
        }
    }
}
