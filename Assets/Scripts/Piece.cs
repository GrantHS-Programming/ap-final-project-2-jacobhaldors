using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3Int postion { get; private set; }
    public void Initalize(Board board, Vector3Int position, TetrominoData data)
    {
        this.board = board;
        this.position;
        this.data = data;
    }
}
