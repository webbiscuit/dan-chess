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

            foreach (Piece piece in board.Squares)
            {
                piece.Should().BeNull();
            }
        }

        [Test]
        public void TestInitialSetup()
        {
            Board board = Board.FromFen("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");

            board["a1"].Should().BeEquivalentTo(new Piece(
                'R', "Rook", Piece.PieceColour.White
            ));
            board["b1"].Should().BeEquivalentTo(new Piece(
                'N', "Knight", Piece.PieceColour.White
            ));
            board["c1"].Should().BeEquivalentTo(new Piece(
                'B', "Bishop", Piece.PieceColour.White
            ));
            board["d1"].Should().BeEquivalentTo(new Piece(
                'Q', "Queen", Piece.PieceColour.White
            ));
            board["e1"].Should().BeEquivalentTo(new Piece(
                'K', "King", Piece.PieceColour.White
            ));
            board["f1"].Should().BeEquivalentTo(new Piece(
                'B', "Bishop", Piece.PieceColour.White
            ));
            board["g1"].Should().BeEquivalentTo(new Piece(
                'N', "Knight", Piece.PieceColour.White
            ));
            board["h1"].Should().BeEquivalentTo(new Piece(
                'R', "Rook", Piece.PieceColour.White
            ));

            board["a2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["b2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["c2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["d2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["e2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["f2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["g2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));
            board["h2"].Should().BeEquivalentTo(new Piece(
                'P', "Pawn", Piece.PieceColour.White
            ));

            board["a7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["b7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["c7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["d7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["e7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["f7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["g7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));
            board["h7"].Should().BeEquivalentTo(new Piece(
                'p', "Pawn", Piece.PieceColour.Black
            ));

            board["a8"].Should().BeEquivalentTo(new Piece(
                'r', "Rook", Piece.PieceColour.Black
            ));
            board["b8"].Should().BeEquivalentTo(new Piece(
                'n', "Knight", Piece.PieceColour.Black
            ));
            board["c8"].Should().BeEquivalentTo(new Piece(
                'b', "Bishop", Piece.PieceColour.Black
            ));
            board["d8"].Should().BeEquivalentTo(new Piece(
                'q', "Queen", Piece.PieceColour.Black
            ));
            board["e8"].Should().BeEquivalentTo(new Piece(
                'k', "King", Piece.PieceColour.Black
            ));
            board["f8"].Should().BeEquivalentTo(new Piece(
                'b', "Bishop", Piece.PieceColour.Black
            ));
            board["g8"].Should().BeEquivalentTo(new Piece(
                'n', "Knight", Piece.PieceColour.Black
            ));
            board["h8"].Should().BeEquivalentTo(new Piece(
                'r', "Rook", Piece.PieceColour.Black
            ));
        }
    }
}