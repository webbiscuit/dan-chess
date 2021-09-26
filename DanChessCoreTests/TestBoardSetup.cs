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

        }
    }
}