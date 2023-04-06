using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OrbitCameraObserver : MonoBehaviour, IOrbitCameraObserverInput
{
    public float Distance;
    public float RotationSpeed;

    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Camera targetCamera;

    private void Awake()
    {
        ResetPosition();
    }

    private void Update()
    {
        targetCamera.transform.LookAt(target.transform.position);
    }

    public void Zoom(float zoom)
    {
        Camera.main.fieldOfView += zoom;
    }

    public void RotateAround(Vector2 angle)
    {
        var rotationAxis = new Vector3(angle.y, angle.x, 0);
        targetCamera.transform.RotateAround(target.transform.position, rotationAxis, RotationSpeed * Time.deltaTime);
    }

    public void ResetPosition()
    {
        targetCamera.transform.position = target.transform.position + (target.transform.forward * Distance);
        targetCamera.transform.LookAt(target.transform.position);
    }
}