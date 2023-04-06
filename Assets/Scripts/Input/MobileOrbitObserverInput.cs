using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileOrbitObserveInput : IOrbitObserverInput
{
    public Vector2 GetPointerDragAxis()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                return new Vector2(touch.deltaPosition.x, touch.deltaPosition.y);
            }
        }

        return Vector2.zero;
    }

    public float GetZoom()
    {
        var zoom = InputUtil.GetTouchZoom();
        return zoom;
    }

    public bool IsStartDragKeyPressed()
    {
        return Input.touchCount >= 1;
    }

    public bool IsResetKeyDown()
    {
        return InputUtil.DetectDoubleTap();
    }
}
