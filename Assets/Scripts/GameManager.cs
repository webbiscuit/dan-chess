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
    HumanPlayer whitePlayer;
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
        whitePlayer = new HumanPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        whitePlayer.CheckForInput();
    }
}
