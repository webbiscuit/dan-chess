using System.Collections.Generic;

namespace DanChessCore.Moves
{
    public class StraightSlider : IMoveGenerator
    {
        // Should be Move??
        public IEnumerable<Square> FindMoves(Square origin, Board board)
        {
            var moves = new List<Square>();

            for (int f = 0; f < Board.Files; f++)
            {
                if (f == origin.Coord.fileIndex)
                {
                    continue;
                }

                moves.Add(board[f, origin.Coord.rankIndex]);
            }

            for (int r = 0; r < Board.Ranks; r++)
            {
                if (r == origin.Coord.rankIndex)
                {
                    continue;
                }

                moves.Add(board[origin.Coord.fileIndex, r]);
            }

            return moves;
        }
    }
}
