using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScaler : MonoBehaviour
{
    
    public void OrderGrids(Box[,] grid)
    {
        Vector3 leftTopPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        foreach (Box box in grid)
        {

        }
    }
}
