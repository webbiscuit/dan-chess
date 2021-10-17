using DanChessCore.Moves;
using System.Collections.Generic;
using System.Linq;

namespace DanChessCore
{
    public class Piece
    {
        public char FenType { get; }
        public string Name { get; }
        public PieceColour Colour { get; }
        public List<IMoveGenerator> Moves { get; }

        public enum PieceColour
        {
            White,
            Black
        }

        public Piece(char type, string name, PieceColour pieceColour, List<IMoveGenerator> moves)
        {
            FenType = type;
            Name = name;
            Colour = pieceColour;
            Moves = moves;
        }

        public IEnumerable<Square> FindMoves(Square origin, Board board)
        {
            foreach (var move in Moves.SelectMany(m => m.FindMoves(origin, board)))
            {
                yield return move;
            }
        }
    }
}
