using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInputHandler : MonoBehaviour, InputHandler
{
    private Box clickedBox;
    private Action clickEvent;
    public void SetSelectEvent(Action clickEvent)
    {
        this.clickEvent = clickEvent;
    }
    public Box GetSelectedBox()
    {
        return clickedBox;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit.transform.tag.Equals("Box"))
            {
                clickedBox = cubeHit.transform.GetComponent<Box>();
                clickEvent();
                Debug.Log("We hit " + cubeHit.collider.name);
            }
        }
    }
}
