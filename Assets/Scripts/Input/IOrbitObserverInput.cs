using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOrbitObserverInput
{
    bool IsResetKeyDown();
    bool IsStartDragKeyPressed();
    Vector2 GetPointerDragAxis();
    float GetZoom();
}