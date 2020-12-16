using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell: MonoBehaviour
{
    public int test = 3;
    [HideInInspector]
    public Vector2Int myPosition;
    [HideInInspector]
    public Board myBoard;
    [HideInInspector]
    public Transform myTransform;

    public void Setup(Vector2Int vec, Board board)
    {
        myPosition = vec;
        myBoard = board;

        myTransform = GetComponent<Transform>();
    }

}
