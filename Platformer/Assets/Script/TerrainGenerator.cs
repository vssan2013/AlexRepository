using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject Cell;
    public GameObject CellWin;
    public Transform Zero;
    public int Height, Width;
    public void Start()
    {
        Generate();
    }
    public void Generate()
    {
        int y = 0;
        int x = 0;
        for (x = 0; x < Width-1; x++)
        {
            var cell = Instantiate(Cell, Zero);
            if (x%2 == 0 && y>-2)
            {
                y += Random.Range(-1, 2);
            }
            cell.transform.localPosition = new Vector3(x, y, 0);
        }

        var cellwin = Instantiate(CellWin, Zero);
        cellwin.transform.localPosition = new Vector3(x, y, 0);
    }
}
