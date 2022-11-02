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
    public List<Box> BreadthFirstSearch(Box[,] grid)
    {
        List<Box> boxesToMark = new List<Box>();
        List<Box> output = new List<Box>();
        List<Box> visited = new List<Box>();
        Queue<Box> queue = new Queue<Box>();
        List<Vector2> searchDirections = directions.GetDirections(DirectionType.FourDirection);

        //while (queue.Count != 0)
        //{

        //}
        return boxesToMark;
    }
}
