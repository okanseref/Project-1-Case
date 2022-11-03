using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScaler : MonoBehaviour
{

    public void OrderGrids(Box[,] grid, int N)
    {
        float height = Camera.main.orthographicSize * 2;
        float boxEdgeLength = height * Camera.main.aspect;
        boxEdgeLength /= N;

        Vector3 startPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        Vector3 currentPosition = startPosition;
        int counter = 0;
        foreach (Box box in grid)
        {
            box.transform.localScale = new Vector3(boxEdgeLength, boxEdgeLength, 1);
            box.transform.position = currentPosition;
            counter++;
            if (counter >= N)
            {
                currentPosition.y -= boxEdgeLength;
                currentPosition.x = startPosition.x;
                counter = 0;
            }
            else
            {
                currentPosition.x += boxEdgeLength;
            }
        }
    }
}
