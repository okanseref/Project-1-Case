using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSearcher : MonoBehaviour
{
    private Directions _directions;
    public void Construct(Directions directions)
    {
        _directions = directions;
    }
    public List<Box> BreadthFirstSearch(Box[,] grid, Box selectedBox)
    {
        List<Box> visited = new List<Box>();
        Queue<Box> queue = new Queue<Box>();
        List<Vector2> searchDirections = _directions.GetDirections(DirectionType.FourDirection);

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
                    if (!visited.Contains(neighborBox) && !queue.Contains(neighborBox) && neighborBox.IsTicked)
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
    private bool CheckBounds(int n, int x, int y)
    {
        if (x < 0 || y < 0 || x >= n || y >= n)
        {
            return false;
        }
        return true;
    }

}