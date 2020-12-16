using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public GameObject cellPrefab;

    public Cell[,] myCells = new Cell[8, 8];

    public void Setup()
    {
        int i, j;

        #region Create Cells
        for (i = 0; i < 8; i++)
        {
            for (j = 0; j < 8; j++)
            {
                // create the cell
                GameObject createdCell = Instantiate(cellPrefab, transform);

                // position the cell
                Transform rectTransform = createdCell.GetComponent<Transform>();
                rectTransform.position = new Vector3(i - 3.5f, (j * -1) + 3.5f, 0);

                Vector2Int pos = new Vector2Int(i, j);
                // setup the cell
                myCells[i, j] = createdCell.GetComponent<Cell>();
                Debug.Log(myCells[i,j].test);
                myCells[i, j].Setup(pos, this as Board);
            }
        }
        #endregion


        #region Set Colors
        for (i = 0; i < 8; i += 2)
        {
            for (j = 0; j < 8; j++)
            {
                // Offset for every other line
                int offset = (j % 2 != 0) ? 0 : 1;
                int finalX = i + offset;

                // Color
                myCells[finalX, j].GetComponent<SpriteRenderer>().color = new Color32(230, 220, 187, 255);
            }
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
