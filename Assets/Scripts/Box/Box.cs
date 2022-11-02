using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public void SetXY(int x,int y)
    {
        X = x;
        Y = y;
    }
}
