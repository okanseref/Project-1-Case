using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSimple : MonoBehaviour
{
    public Box[,] Grid { get; private set; }

    public void InitializeGrid(int edgeLength)
    {
        Grid = new Box[edgeLength, edgeLength];
        for (int i = 0; i < edgeLength; i++)
        {
            for (int j = 0; j < edgeLength; j++)
            {
                Box newBox = PoolManager.Instance.BoxPool.GetObject().GetComponent<Box>();
                newBox.gameObject.SetActive(true);
                newBox.SetXY(i, j);
                newBox.SetTick(false);
                Grid[i, j] = newBox;
            }
        }
    }
    public void RemoveGrid()
    {
        int edgeLength = Grid.GetLength(0);
        for (int i = 0; i < edgeLength; i++)
        {
            for (int j = 0; j < edgeLength; j++)
            {
                PoolManager.Instance.BoxPool.ReturnObject(Grid[i, j].gameObject);
            }
        }
    }
}
