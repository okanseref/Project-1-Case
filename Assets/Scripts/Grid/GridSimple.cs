using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSimple : MonoBehaviour
{
    public Box[,] grid { get; private set; }

    public void InitializeGrid(int N)
    {
        grid = new Box[N,N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Box newBox = PoolManager.instance.boxPool.GetObject().GetComponent<Box>();
                newBox.gameObject.SetActive(true);
                newBox.SetXY(i, j);
                newBox.SetTick(false);
                grid[i, j] = newBox;
            }
        }
    }
}
