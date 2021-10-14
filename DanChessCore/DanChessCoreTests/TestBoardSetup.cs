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

            board["a1"].Piece.Should().BeEquivalentTo(new Piece(
                'R', "Rook", Piece.PieceColour.White
            ));
            board["b1"].Piece.Should().BeEquivalentTo(new Piece(
                'N', "Knight", Piece.PieceColour.White
            ));
            board["c1"].Piece.Should().BeEquivalentTo(new Piece(
                'B', "Bishop", Piece.PieceColour.White
            ));
            board["d1"].Piece.Should().BeEquivalentTo(new Piece(
                'Q', "Queen", Piece.PieceColour.White
            ));
            board["e1"].Piece.Should().BeEquivalentTo(new Piece(
                'K', "King", Piece.PieceColour.White
            ));
            board["f1"].Piece.Should().BeEquivalentTo(new Piece(
                'B', "Bishop", Piece.PieceColour.White
            ));
            board["g1"].Piece.Should().BeEquivalentTo(new Piece(
                'N', "Knight", Piece.PieceColour.White
            ));
            board["h1"].Piece.Should().BeEquivalentTo(new Piece(
                'R', "Rook", Piece.PieceColour.White
            ));

            board["a2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["b2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["c2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["d2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["e2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["f2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["g2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["h2"].Piece.Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));

            board["a7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["b7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["c7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["d7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["e7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["f7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["g7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["h7"].Piece.Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));

            board["a8"].Piece.Should().BeEquivalentTo(new Piece(
                'r', "Rook", Piece.PieceColour.Black
            ));
            board["b8"].Piece.Should().BeEquivalentTo(new Piece(
                'n', "Knight", Piece.PieceColour.Black
            ));
            board["c8"].Piece.Should().BeEquivalentTo(new Piece(
                'b', "Bishop", Piece.PieceColour.Black
            ));
            board["d8"].Piece.Should().BeEquivalentTo(new Piece(
                'q', "Queen", Piece.PieceColour.Black
            ));
            board["e8"].Piece.Should().BeEquivalentTo(new Piece(
                'k', "King", Piece.PieceColour.Black
            ));
            board["f8"].Piece.Should().BeEquivalentTo(new Piece(
                'b', "Bishop", Piece.PieceColour.Black
            ));
            board["g8"].Piece.Should().BeEquivalentTo(new Piece(
                'n', "Knight", Piece.PieceColour.Black
            ));
            board["h8"].Piece.Should().BeEquivalentTo(new Piece(
                'r', "Rook", Piece.PieceColour.Black
            ));
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