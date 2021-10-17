using DanChessCore;
using NUnit.Framework;
using FluentAssertions;

namespace DanChessCoreTests
{
    public class TestBoardSetup
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEmptyBoards()
        {
            Board board = new Board();

            foreach (Square square in board.Squares)
            {
                square.Piece.Should().BeNull();
            }
        }

        [Test]
        public void TestInitialSetup()
        {
            Board board = Board.FromFen("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");

            board["a1"].Piece.Name.Should().Be("Rook");
            board["a1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["b1"].Piece.Name.Should().Be("Knight");
            board["b1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["c1"].Piece.Name.Should().Be("Bishop");
            board["c1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["d1"].Piece.Name.Should().Be("Queen");
            board["d1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["e1"].Piece.Name.Should().Be("King");
            board["e1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["f1"].Piece.Name.Should().Be("Bishop");
            board["f1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["g1"].Piece.Name.Should().Be("Knight");
            board["g1"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["h1"].Piece.Name.Should().Be("Rook");
            board["h1"].Piece.Colour.Should().Be(Piece.PieceColour.White);

            board["a2"].Piece.Name.Should().Be("Pawn");
            board["a2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["b2"].Piece.Name.Should().Be("Pawn");
            board["b2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["c2"].Piece.Name.Should().Be("Pawn");
            board["c2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["d2"].Piece.Name.Should().Be("Pawn");
            board["d2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["e2"].Piece.Name.Should().Be("Pawn");
            board["e2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["f2"].Piece.Name.Should().Be("Pawn");
            board["f2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["g2"].Piece.Name.Should().Be("Pawn");
            board["g2"].Piece.Colour.Should().Be(Piece.PieceColour.White);
            board["h2"].Piece.Name.Should().Be("Pawn");
            board["h2"].Piece.Colour.Should().Be(Piece.PieceColour.White);

            board["a7"].Piece.Name.Should().Be("Pawn");
            board["a7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["b7"].Piece.Name.Should().Be("Pawn");
            board["b7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["c7"].Piece.Name.Should().Be("Pawn");
            board["c7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["d7"].Piece.Name.Should().Be("Pawn");
            board["d7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["e7"].Piece.Name.Should().Be("Pawn");
            board["e7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["f7"].Piece.Name.Should().Be("Pawn");
            board["f7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["g7"].Piece.Name.Should().Be("Pawn");
            board["g7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["h7"].Piece.Name.Should().Be("Pawn");
            board["h7"].Piece.Colour.Should().Be(Piece.PieceColour.Black);

            board["a8"].Piece.Name.Should().Be("Rook");
            board["a8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["b8"].Piece.Name.Should().Be("Knight");
            board["b8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["c8"].Piece.Name.Should().Be("Bishop");
            board["c8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["d8"].Piece.Name.Should().Be("Queen");
            board["d8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["e8"].Piece.Name.Should().Be("King");
            board["e8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["f8"].Piece.Name.Should().Be("Bishop");
            board["f8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["g8"].Piece.Name.Should().Be("Knight");
            board["g8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
            board["h8"].Piece.Name.Should().Be("Rook");
            board["h8"].Piece.Colour.Should().Be(Piece.PieceColour.Black);
        }

        [Test]
        public void TestSinglePiece()
        {
            Board board = Board.FromFen("r7/8/8/8/8/8/8/8 w KQkq - 0 1");
            var piece = board["a8"].Piece;
            piece.Name.Should().Be("Rook");
            piece.FenType.Should().Be('r');
            piece.Colour.Should().Be(Piece.PieceColour.Black);
        }
    } 
}