using UnityEngine;

[CreateAssetMenu(menuName = "Theme/Board")]
public class BoardTheme : ScriptableObject
{
	public SquareColours lightSquares;
	public SquareColours darkSquares;

	[System.Serializable]
	public struct SquareColours
	{
		public Color normal;
	}
}