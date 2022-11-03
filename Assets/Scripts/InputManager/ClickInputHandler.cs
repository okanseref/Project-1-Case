using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInputHandler : MonoBehaviour, InputHandler
{
    private Box _clickedBox;
    private Action _clickEvent;
    public void SetSelectEvent(Action clickEvent)
    {
        _clickEvent = clickEvent;
    }
    public Box GetSelectedBox()
    {
        return _clickedBox;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit.transform != null && cubeHit.transform.tag.Equals("Box"))
            {
                _clickedBox = cubeHit.transform.GetComponent<Box>();
                _clickEvent();
            }
        }
    }
}
