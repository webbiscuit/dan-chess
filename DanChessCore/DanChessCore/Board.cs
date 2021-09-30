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
            get => IsInBoard(index) ? Squares[index] : null;
        }

        public Piece this[int file, int rank]
        {
            get => IsInBoard(file, rank) ? Squares[rank * Ranks + file] : null;
        }

        public Piece this[string squareName]
        {
            get => Squares[IndexFromSquareName(squareName)];
        }

        public bool IsInBoard(int file, int rank)
        {
            return file >= 0 && file < Files && rank >= 0 && rank < Ranks;
        }

        public bool IsInBoard(int index)
        {
            return index >= 0 && index < Files * Ranks;
        }

        private Piece[] _Squares;

        private const string fileNames = "abcdefgh";
        private const string rankNames = "12345678";

        public Board()
        {
            _Squares = new Piece[Ranks * Files];
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
