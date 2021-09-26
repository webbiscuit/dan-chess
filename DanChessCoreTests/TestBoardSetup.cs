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
    }
}