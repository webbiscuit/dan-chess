using DanChessCore.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore.FileFormats
{
    public static class FenFormat
    {
        //public static readonly string NormalStartingBoard = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        public static readonly string NormalStartingBoard = "r7/8/8/8/8/8/8/8 w KQkq - 0 1";

        public static BoardSetup ToBoardSetup(string fen)
        {
            var boardSetup = new BoardSetup();

            var sections = fen.Split(' ');

            int file = 0;
            int rank = 7;

            foreach (char symbol in sections[0])
            {
                if (char.IsDigit(symbol))
                {
                    file += (int)char.GetNumericValue(symbol);
                }
                else if (symbol == '/')
                {
                    rank--;
                    file = 0;
                }
                else
                {
                    boardSetup[file, rank] = ToPiece(symbol);
                    file++;
                }
            }

            return boardSetup;
        }

        public static Piece ToPiece(char p)
        {
            var colour = char.IsUpper(p) ? Piece.PieceColour.White : Piece.PieceColour.Black;

            switch (char.ToUpper(p))
            {
                case 'P':
                    return new Piece(p, "Pawn", colour, new List<IMoveGenerator>());
                case 'R':
                    return new Piece(p, "Rook", colour, new List<IMoveGenerator>());
                case 'N':
                    return new Piece(p, "Knight", colour, new List<IMoveGenerator>());
                case 'B':
                    return new Piece(p, "Bishop", colour, new List<IMoveGenerator>());
                case 'Q':
                    return new Piece(p, "Queen", colour, new List<IMoveGenerator>());
                case 'K':
                    return new Piece(p, "King", colour, new List<IMoveGenerator>());
            }

            throw new PieceException($"Unsupported fen type: {p}");
        }
    }
}
