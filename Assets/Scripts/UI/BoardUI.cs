using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardUI : MonoBehaviour
{
	const int Ranks = 8;
	const int Files = 8;

	MeshRenderer[,] squareRenderers = new MeshRenderer[Files, Ranks];
	SpriteRenderer[,] squarePieceRenderers = new SpriteRenderer[Files, Ranks];

	void Awake()
	{
		CreateBoardUI();
	}

    private void CreateBoardUI()
    {
		Shader squareShader = Shader.Find("Unlit/Color");
		//squareRenderers = new MeshRenderer[8, 8];
		//squarePieceRenderers = new SpriteRenderer[8, 8];

		for (int rank = 0; rank < Ranks; rank++)
		{
			for (int file = 0; file < Files; file++)
			{
				// Create square
				Transform square = GameObject.CreatePrimitive(PrimitiveType.Quad).transform;
				square.parent = transform;
				//square.name = BoardRepresentation.SquareNameFromCoordinate(file, rank);
				//square.position = PositionFromCoord(file, rank, 0);
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

		//ResetSquareColours();
	}
}
