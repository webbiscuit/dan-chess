using System.Collections.Generic;

namespace DanChessCore
{
    public class Piece
    {
        public char FenType { get; }
        public string Name { get; }
        public PieceColour Colour { get; }

        public enum PieceColour
        {
            White,
            Black
        }

        public Piece(char type, string name, PieceColour pieceColour)
        {
            FenType = type;
            Name = name;
            Colour = pieceColour;
        }

        public List<Square> FindMoves()
        {
            return new List<Square>();
        }
    }
}
