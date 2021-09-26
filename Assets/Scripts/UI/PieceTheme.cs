using Assets.Scripts;
using Assets.Scripts.DanChess;
using UnityEngine;


[CreateAssetMenu(menuName = "Theme/Pieces")]
public class PieceTheme : ScriptableObject
{
    public PieceSprites whitePieces;
    public PieceSprites blackPieces;

	public Sprite GetPieceSprite(Piece piece)
	{
        if (piece == null)
        {
            return null;
        }

        PieceSprites pieceSprites = piece.Colour == Piece.PieceColour.White ? whitePieces : blackPieces;

        switch (piece.Name)
        {
            case "Pawn":
                return pieceSprites.Pawn;
            case "Rook":
                return pieceSprites.Rook;
            case "Knight":
                return pieceSprites.Knight;
            case "Bishop":
                return pieceSprites.Bishop;
            case "Queen":
                return pieceSprites.Queen;
            case "King":
                return pieceSprites.King;
            default:
                throw new PieceException($"Don't know how to draw - {piece.Name}");
        }
    }



	[System.Serializable]
	public class PieceSprites
	{
		public Sprite Pawn, Rook, Knight, Bishop, Queen, King;
	}
}
