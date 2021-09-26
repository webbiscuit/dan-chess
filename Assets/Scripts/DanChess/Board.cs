using Assets.Scripts.DanChess;
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

        public Piece[] Squares { get; }

        public Piece this[int index]
        {
            get => Squares[index];
        }

        public Piece this[int file, int rank]
        {
            get => Squares[rank * Ranks + file];
        }

        private const string fileNames = "abcdefgh";
        private const string rankNames = "12345678";

        public Board()
        {
            Squares = new Piece[Ranks * Files];

            Squares[32] = new Piece('K', "King", Piece.PieceColour.White);
            Squares[33] = new Piece('K', "King", Piece.PieceColour.Black);
            Squares[34] = new Piece('K', "Queen", Piece.PieceColour.White);
            Squares[35] = new Piece('K', "Knight", Piece.PieceColour.Black);
        }

        public static string GetSquareName(int file, int rank)
        {
            return fileNames[file] + "" + (rank + 1);
        }
    }
}
