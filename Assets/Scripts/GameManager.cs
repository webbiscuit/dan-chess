using DanChessCore;
using DanChessCore.FileFormats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    BoardUI boardUI;
    Board board;
    //Player whitePlayer;
    //Player blackPlayer;

    // Start is called before the first frame update
    void Start()
    {
        boardUI = FindObjectOfType<BoardUI>();
        board = new Board();
        boardUI.SetBoard(board);

        NewGame();
    }

    private void NewGame()
    {
        board = Board.FromFen(FenFormat.NormalStartingBoard);
        boardUI.SetBoard(board);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
