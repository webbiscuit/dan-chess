using DanChess;
using UnityEngine;

namespace Chess.UI
{
	public class BoardUI : MonoBehaviour
	{
		public BoardTheme boardTheme;

		Board board = new Board();
		MeshRenderer[,] squareRenderers = new MeshRenderer[Board.Files, Board.Ranks];
		SpriteRenderer[,] squarePieceRenderers = new SpriteRenderer[Board.Files, Board.Ranks];


		void Awake()
		{
			CreateBoardUI();
		}

		private void CreateBoardUI()
		{
			Shader squareShader = Shader.Find("Unlit/Color");
			//squareRenderers = new MeshRenderer[8, 8];
			//squarePieceRenderers = new SpriteRenderer[8, 8];

			for (int rank = 0; rank < Board.Ranks; rank++)
			{
				for (int file = 0; file < Board.Files; file++)
				{
					// Create square
					Transform square = GameObject.CreatePrimitive(PrimitiveType.Quad).transform;
					square.parent = transform;
					square.name = Board.GetSquareName(file, rank);
					square.position = PositionFromCoord(file, rank);
					Material squareMaterial = new Material(squareShader);

					squareRenderers[file, rank] = square.gameObject.GetComponent<MeshRenderer>();
					squareRenderers[file, rank].material = squareMaterial;

					//// Create piece sprite renderer for current square
					//SpriteRenderer pieceRenderer = new GameObject("Piece").AddComponent<SpriteRenderer>();
					//pieceRenderer.transform.parent = square;
					//pieceRenderer.transform.position = PositionFromCoord(file, rank, pieceDepth);
					//pieceRenderer.transform.localScale = Vector3.one * 100 / (2000 / 6f);
					//squarePieceRenderers[file, rank] = pieceRenderer;
				}
			}

			ResetSquareColours();
		}

		public Vector3 PositionFromCoord(int file, int rank)
		{
			return new Vector3(-3.5f + file, -3.5f + rank, 0);
		}

		private void ResetSquareColours()
		{
			for (int rank = 0; rank < Board.Ranks; rank++)
			{
				for (int file = 0; file < Board.Files; file++)
				{
					SetSquareColour(new Coord(file, rank), boardTheme.lightSquares.normal, boardTheme.darkSquares.normal);
				}
			}
		}

		void SetSquareColour(Coord square, Color lightCol, Color darkCol)
		{
			squareRenderers[square.fileIndex, square.rankIndex].material.color = (square.IsLightSquare()) ? lightCol : darkCol;
		}
	}
}
