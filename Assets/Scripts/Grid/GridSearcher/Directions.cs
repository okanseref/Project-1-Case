using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour
{
    public List<Vector2> GetDirections(DirectionType directionType)
    {
        List<Vector2> directions = new List<Vector2>();
        switch (directionType)
        {
            case DirectionType.FourDirection:
                directions.Add(new Vector2(1, 0));
                directions.Add(new Vector2(-1, 0));
                directions.Add(new Vector2(0, 1));
                directions.Add(new Vector2(0, -1));
                break;
            case DirectionType.EightDirection:
                directions.Add(new Vector2(1, 0));
                directions.Add(new Vector2(-1, 0));
                directions.Add(new Vector2(0, 1));
                directions.Add(new Vector2(0, -1));
                directions.Add(new Vector2(1, 1));
                directions.Add(new Vector2(-1, -1));
                directions.Add(new Vector2(-1, 1));
                directions.Add(new Vector2(1, -1));
                break;
        }
        return directions;
    }
}
public enum DirectionType
{
    FourDirection,
    EightDirection
}