using DanChessCore;
using NUnit.Framework;
using FluentAssertions;
using System.Linq;

namespace DanChessCoreTests
{
    public class TestMoves
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStraightSlider()
        {
            Board board = Board.FromFen("r7/8/8/8/8/8/8/8 w KQkq - 0 1");
            var piece = board["a8"].Piece;
            piece.Name.Should().Be("Rook");
            board["a8"].Name.Should().Be("a8");

            piece.FindMoves(board["a8"], board).Select(s => s.Name).Should().BeEquivalentTo(
                "a7", "a6", "a5", "a4", "a3", "a2", "a1",
                "b8", "c8", "d8", "e8", "f8", "g8", "h8");
        }

        [Test]
        public void TestRook()
        {
            Board board = Board.FromFen("8/1r6/8/8/8/8/8/8 w KQkq - 0 1");
            var piece = board["b7"].Piece;
            piece.Name.Should().Be("Rook");
            board["b7"].Name.Should().Be("b7");

            piece.FindMoves(board["b7"], board).Select(s => s.Name).Should().BeEquivalentTo(
                "b8", "b6", "b5", "b4", "b3", "b2", "b1",
                "a7", "c7", "d7", "e7", "f7", "g7", "h7");
        }
    }
}