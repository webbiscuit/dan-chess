using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanChessCore
{
    public class BoardSetup
    {
		public Piece[] Squares { get; }

		public BoardSetup()
		{
			Squares = new Piece[64];
		}
	}
}
