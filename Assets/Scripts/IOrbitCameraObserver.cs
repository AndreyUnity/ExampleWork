using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOrbitCameraObserverInput
{
    void ResetPosition();
    void RotateAround(Vector2 axis);
    void Zoom(float zoom);
}
