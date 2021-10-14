using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore
{
    public class Square
    {
        public Coord Coord { get; private set; }
        public Piece Piece { get; private set; }
        public string Name { get => Board.GetSquareName(Coord.fileIndex, Coord.rankIndex); }

        public Square(Coord coord)
        {
            this.Coord = coord;
        }

        public Square(int fileIndex, int rankIndex)
        {
            this.Coord = new Coord(fileIndex, rankIndex);
        }

        public bool IsLightSquare()
        {
            return (Coord.fileIndex + Coord.rankIndex) % 2 != 0;
        }

        public void RemovePiece()
        {
            Piece = null;
        }

        public void PlacePiece(Piece piece)
        {
            Piece = piece;
        }
    }
}
