namespace DanChessCore
{
    public struct Coord //: IComparable<Coord>
	{
		public readonly int fileIndex;
		public readonly int rankIndex;

		public Coord(int fileIndex, int rankIndex)
		{
			this.fileIndex = fileIndex;
			this.rankIndex = rankIndex;
		}

		public bool IsLightSquare()
		{
			return (fileIndex + rankIndex) % 2 != 0;
		}

        public override string ToString()
        {
			return $"File {fileIndex} - Index {rankIndex}";
		}

        //public int CompareTo(Coord other)
        //{
        //	return (fileIndex == other.fileIndex && rankIndex == other.rankIndex) ? 0 : 1;
        //}
    }
}