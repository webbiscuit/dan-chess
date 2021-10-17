using System.Collections.Generic;

namespace DanChessCore.Moves
{
    public class StraightSlider : IMoveGenerator
    {
        // Should be Move??
        public IEnumerable<Square> FindMoves(Square origin, Board board)
        {
            var moves = new List<Square>();

            for (int f = 0; f < origin.Coord.fileIndex; f++)
            {
                moves.Add(board[f, origin.Coord.rankIndex]);
            }

            for (int f = origin.Coord.fileIndex + 1; f < Board.Files; f++)
            {
                moves.Add(board[f, origin.Coord.rankIndex]);
            }

            for (int r = 0; r < origin.Coord.rankIndex; r++)
            {
                moves.Add(board[origin.Coord.fileIndex, r]);
            }

            for (int r = origin.Coord.rankIndex + 1; r < Board.Ranks; r++)
            {
                moves.Add(board[origin.Coord.fileIndex, r]);
            }

            return moves;
        }
    }
}
