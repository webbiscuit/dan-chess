using DanChessCore.FileFormats;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DanChessCore
{
    public class Board
    {
        public const int Ranks = 8;
        public const int Files = 8;

        public ReadOnlyCollection<Piece> Squares { get { return Array.AsReadOnly(_Squares); } }

        public Piece this[int index]
        {
            get => Squares[index];
        }

        public Piece this[int file, int rank]
        {
            get => Squares[rank * Ranks + file];
        }

        public Piece this[string squareName]
        {
            get => Squares[IndexFromSquareName(squareName)];
        }

        private Piece[] _Squares;

        private const string fileNames = "abcdefgh";
        private const string rankNames = "12345678";

        public Board()
        {
            _Squares = new Piece[Ranks * Files];

            //Squares[32] = new Piece('K', "King", Piece.PieceColour.White);
            //Squares[33] = new Piece('K', "King", Piece.PieceColour.Black);
            //Squares[34] = new Piece('K', "Queen", Piece.PieceColour.White);
            //Squares[35] = new Piece('K', "Knight", Piece.PieceColour.Black);
        }

        public Board(BoardSetup setup) : this()
        {
            setup.Squares.CopyTo(_Squares, 0);
        }

        public void LayoutFromFen(string fen)
        {
            BoardSetup setup = FenFormat.ToBoardSetup(fen);
            setup.Squares.CopyTo(_Squares, 0);
        }

        public static Board FromFen(string fen)
        {
            BoardSetup setup = FenFormat.ToBoardSetup(fen);
            Board board = new Board(setup);

            return board;
        }

        public static string GetSquareName(int file, int rank)
        {
            return fileNames[file] + "" + (rank + 1);
        }

        public int IndexFromSquareName(string name)
        {
            return fileNames.IndexOf(name[0]) + rankNames.IndexOf(name[1]) * Ranks;
        }
    }
}
