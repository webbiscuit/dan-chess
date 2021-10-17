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

        public ReadOnlyCollection<Square> Squares { get { return Array.AsReadOnly(_Squares); } }

        public Square this[int index]
        {
            get => IsInBoard(index) ? Squares[index] : null;
        }

        public Square this[Coord coord]
        {
            get => this[coord.fileIndex, coord.rankIndex];
            private set => this[coord.fileIndex, coord.rankIndex] = value;
        }

        public Square this[int file, int rank]
        {
            get => IsInBoard(file, rank) ? Squares[rank * Ranks + file] : null;
            private set => _Squares[rank * Ranks + file] = value;
        }

        public Square this[string squareName]
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

        public void MovePiece(Coord from, Coord to)
        {
            Piece piece = this[from].Piece;
            this[from].RemovePiece();
            this[to].PlacePiece(piece);
        }

        private Square[] _Squares;

        private const string fileNames = "abcdefgh";
        private const string rankNames = "12345678";

        public Board()
        {
            _Squares = new Square[Ranks * Files];

            for (int rank = 0; rank < Board.Ranks; rank++)
            {
                for (int file = 0; file < Board.Files; file++)
                {
                    Coord coord = new Coord(file, rank);
                    this[coord] = new Square(coord);
                }
            }
        }

        public Board(BoardSetup setup)
        {
            _Squares = new Square[Ranks * Files];

            for (int i = 0; i < setup.Squares.Length; i++)
            {
                _Squares[i] = new Square(CoordFromIndex(i));
                _Squares[i].PlacePiece(setup.Squares[i]);
            }
        }

        public void LayoutFromFen(string fen)
        {
            BoardSetup setup = FenFormat.ToBoardSetup(fen);

            for (int i = 0; i < setup.Squares.Length; i++)
            {
                _Squares[i] = new Square(CoordFromIndex(i));
                _Squares[i].PlacePiece(setup.Squares[i]);
            }
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

        public static int IndexFromSquareName(string name)
        {
            return fileNames.IndexOf(name[0]) + rankNames.IndexOf(name[1]) * Ranks;
        }

        public static Coord CoordFromIndex(int index)
        {
            return new Coord(index % Files, index / Ranks);
        }
    }
}
