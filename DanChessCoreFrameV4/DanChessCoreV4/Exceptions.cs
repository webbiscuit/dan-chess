using System;

namespace DanChessCore
{
    [Serializable]
    public class DanChessException : Exception
    {
        public DanChessException() { }
        public DanChessException(string message) : base(message) { }
        public DanChessException(string message, Exception inner) : base(message, inner) { }
        protected DanChessException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class PieceException : Exception
    {
        public PieceException() { }
        public PieceException(string message) : base(message) { }
        public PieceException(string message, Exception inner) : base(message, inner) { }
        protected PieceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
