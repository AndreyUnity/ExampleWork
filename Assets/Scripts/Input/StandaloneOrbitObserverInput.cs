using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandaloneOrbitObserverInput : IOrbitObserverInput
{
    public Vector2 GetPointerDragAxis()
    {
        return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }

    public bool IsResetKeyDown()
    {
        return Input.GetMouseButtonDown(1);
    }

    public bool IsStartDragKeyPressed()
    {
        return Input.GetMouseButton(0);
    }

    public float GetZoom()
    {
        return Input.GetAxis("Mouse ScrollWheel");
    }
}
