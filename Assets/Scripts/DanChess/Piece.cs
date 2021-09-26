using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DanChess
{
    public class Piece
    {
        public char Type { get; }
        public string Name { get; }
        public PieceColour Colour { get; }

        public enum PieceColour
        {
            White,
            Black
        }

        public Piece(char type, string name, PieceColour pieceColour)
        {
            Type = type;
            Name = name;
            Colour = pieceColour;
        }
    }
}
