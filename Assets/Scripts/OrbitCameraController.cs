using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OrbitCameraController : MonoBehaviour, IUserAbility
{
    public bool Locked => locked;
    private bool locked = false;

    [Inject]
    private IOrbitCameraObserverInput orbitCamera;
    [Inject]
    private IOrbitObserverInput input;

    public void Lock()
    {
        locked = true;
    }

    public void Unlock()
    {
        locked = false;
    }

    public void Update()
    {
        if (locked) return;

        if (input.IsStartDragKeyPressed())
        {
            var pointerInput = input.GetPointerDragAxis();
            orbitCamera.RotateAround(pointerInput);
        }

        if (input.IsResetKeyDown())
        {
            orbitCamera.ResetPosition();
        }

        orbitCamera.Zoom(input.GetZoom());
    }
}
