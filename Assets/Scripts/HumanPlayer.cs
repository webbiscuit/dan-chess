using DanChessCore;
using UnityEngine;

class HumanPlayer
{
	BoardUI boardUI;
	Camera cam;

	public enum InputState
	{
		None,
		PieceSelected,
		DraggingPiece
	}

	InputState currentState = InputState.None;
	Coord? selectedPieceSquare;

	public HumanPlayer()
	{
		boardUI = GameObject.FindObjectOfType<BoardUI>();
		cam = Camera.main;
	}

	public void CheckForInput()
    {
		Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

		if (currentState == InputState.None)
		{
			HandlePieceSelection(mousePos);
		}
		else if (currentState == InputState.DraggingPiece)
		{
			HandleDragMovement(mousePos);
		}
	}

    private void HandleDragMovement(Vector2 mousePos)
    {
		if (selectedPieceSquare.HasValue)
		{
			boardUI.DragPiece(selectedPieceSquare.Value, mousePos);
		}

		if (Input.GetMouseButtonUp(0))
		{
			HandlePiecePlacement(mousePos);
		}
	}

	void HandlePiecePlacement(Vector2 mousePos)
	{
		currentState = InputState.None;
	}

	void HandlePieceSelection(Vector2 mousePos)
	{
		if (Input.GetMouseButtonDown(0))
		{
			selectedPieceSquare = boardUI.GetCoordUnderMouse(mousePos);

			if (selectedPieceSquare != null)
			{
				// Check piece colour
				currentState = InputState.DraggingPiece;
			}
		}
	}
}
