using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InputHandler 
{
    public void SetSelectEvent(Action clickEvent);
    public Box GetSelectedBox();
}
