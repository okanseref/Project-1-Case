using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSearcher : MonoBehaviour
{
    private Directions directions;
    public void Construct(Directions directions)
    {
        this.directions = directions;
    }
    public List<Box> BreadthFirstSearch(Box[,] grid, Box selectedBox)
    {
        List<Box> visited = new List<Box>();
        Queue<Box> queue = new Queue<Box>();
        List<Vector2> searchDirections = directions.GetDirections(DirectionType.FourDirection);

        queue.Enqueue(selectedBox);
        while (queue.Count != 0)
        {
            Box currentBox = queue.Dequeue();
            visited.Add(currentBox);
            foreach (Vector2 direction in searchDirections)
            {
                int neighborX = currentBox.X + (int)direction.x;
                int neighborY = currentBox.Y + (int)direction.y;
                if (CheckBounds(grid.GetLength(0), neighborX, neighborY))
                {
                    Box neighborBox = grid[neighborX, neighborY];
                    if (!visited.Contains(neighborBox) && !queue.Contains(neighborBox) && neighborBox.isTicked)
                    {
                        queue.Enqueue(neighborBox);
                    }
                }
            }
        }
        if (visited.Count < 3)
        {
            visited.Clear();
        }
        return visited;
    }
    private bool CheckBounds(int N, int X, int Y)
    {
        if (X < 0 || Y < 0 || X >= N || Y >= N)
        {
            return false;
        }
        return true;
    }

}