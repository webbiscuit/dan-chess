using DanChessCore;
using DanChessCore.FileFormats;
using System;
using UnityEngine;

public class BoardUI : MonoBehaviour
{
	public BoardTheme boardTheme;
	public PieceTheme pieceTheme;
	private Board board;

	MeshRenderer[,] squareRenderers = new MeshRenderer[Board.Files, Board.Ranks];
	SpriteRenderer[,] squarePieceRenderers = new SpriteRenderer[Board.Files, Board.Ranks];

	const float boardDepth = 0f;
	const float pieceDepth = -0.1f;
	const float pieceDragDepth = -0.2f;

	public void SetBoard(Board board)
	{
		this.board = board;
		CreateBoardUI();
	}

	private void CreateBoardUI()
	{
		Shader squareShader = Shader.Find("Unlit/Color");

		for (int rank = 0; rank < Board.Ranks; rank++)
		{
			for (int file = 0; file < Board.Files; file++)
			{
				// Create square
				Transform square = GameObject.CreatePrimitive(PrimitiveType.Quad).transform;
				square.parent = transform;
				square.name = Board.GetSquareName(file, rank);
				square.position = PositionFromCoord(file, rank, boardDepth);
				Material squareMaterial = new Material(squareShader);

				squareRenderers[file, rank] = square.gameObject.GetComponent<MeshRenderer>();
				squareRenderers[file, rank].material = squareMaterial;

                // Create piece sprite renderer for current square
                SpriteRenderer pieceRenderer = new GameObject("Piece").AddComponent<SpriteRenderer>();
                pieceRenderer.transform.parent = square;
                pieceRenderer.transform.position = PositionFromCoord(file, rank, pieceDepth);
                pieceRenderer.transform.localScale = Vector3.one * 100 / (1200 / 6f);
                squarePieceRenderers[file, rank] = pieceRenderer;
            }
		}

		ResetSquareColours();
		ShowPieces();
	}

    public void DragPiece(Coord coord, Vector2 mousePos)
    {
		squarePieceRenderers[coord.fileIndex, coord.rankIndex].transform.position = new Vector3(mousePos.x, mousePos.y, pieceDragDepth);
    }

    public Vector3 PositionFromCoord(int file, int rank, float depth)
	{
		return new Vector3(-3.5f + file, -3.5f + rank, depth);
	}

	public Coord? GetCoordUnderMouse(Vector2 mouseWorld)
	{
		int file = (int)Math.Floor(mouseWorld.x + 4);
		int rank = (int)Math.Floor(mouseWorld.y + 4);

		if (IsInBoard(file, rank))
		{
			return new Coord(file, rank);
		}

		return null;
	}

	public bool IsInBoard(int file, int rank)
	{
		return file >= 0 && file < Board.Files && rank >= 0 && rank < Board.Ranks;
	}

	public bool TryGetSquareUnderMouse(Vector2 mouseWorld, out Coord selectedCoord)
	{
		int file = (int)Math.Floor(mouseWorld.x + 4);
		int rank = (int)Math.Floor(mouseWorld.y + 4);

		selectedCoord = new Coord(file, rank);
		return file >= 0 && file < 8 && rank >= 0 && rank < 8;
	}

	private void ResetSquareColours()
	{
		for (int rank = 0; rank < Board.Ranks; rank++)
		{
			for (int file = 0; file < Board.Files; file++)
			{
				var coord = new Coord(file, rank);
				SetSquareColour(coord, (coord.IsLightSquare()) ? boardTheme.lightSquares.normal : boardTheme.darkSquares.normal);
			}
		}
	}

	private void SetSquareColour(Coord square, Color colour)
	{
		squareRenderers[square.fileIndex, square.rankIndex].material.color = colour;
	}

	private void ShowPieces()
	{
		for (int rank = 0; rank < Board.Ranks; rank++)
		{
			for (int file = 0; file < Board.Files; file++)
			{
				ShowPiece(new Coord(file, rank), board[file, rank]);
			}
		}
	}

	private void ShowPiece(Coord square, Piece piece)
	{
        squarePieceRenderers[square.fileIndex, square.rankIndex].sprite = pieceTheme.GetPieceSprite(piece);
        squarePieceRenderers[square.fileIndex, square.rankIndex].transform.position = 
			PositionFromCoord(square.fileIndex, square.rankIndex, pieceDepth);
	}

	public void ResetPiecePosition(Coord startCoord, Coord endCoord)
	{
		var piece = board[startCoord];
		ShowPiece(startCoord, piece);
		Debug.Log(startCoord);
		Debug.Log(piece);
	}
}

