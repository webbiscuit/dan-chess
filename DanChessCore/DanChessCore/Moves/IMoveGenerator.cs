using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore.Moves
{
    public interface IMoveGenerator
    {
        IEnumerable<Square> FindMoves(Square origin, Board board);
    }
}
