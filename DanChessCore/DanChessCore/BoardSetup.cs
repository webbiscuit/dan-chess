using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore
{
    public class BoardSetup
    {
        public const int Ranks = 8;
        public const int Files = 8;

        public Piece[] Squares { get; }

        public Piece this[int index]
        {
            get => Squares[index];
            set => Squares[index] = value;
        }

        public Piece this[int file, int rank]
        {
            get => Squares[rank * Ranks + file];
            set => Squares[rank * Ranks + file] = value;
        }

        public BoardSetup()
		{
			Squares = new Piece[64];
		}
	}
}
