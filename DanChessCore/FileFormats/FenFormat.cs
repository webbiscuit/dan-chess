using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore.FileFormats
{
    public static class FenFormat
    {
        public static BoardSetup ToBoardSetup(string fen)
        {
            var boardSetup = new BoardSetup();

            boardSetup.Squares[0] = new Piece('R', "Rook", Piece.PieceColour.White);

            return boardSetup;
        }
    }
}
