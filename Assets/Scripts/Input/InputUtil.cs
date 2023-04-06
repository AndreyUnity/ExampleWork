using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputUtil
{
    public static bool DetectDoubleTap()
    {
        foreach (var touch in Input.touches)
        {
            if (touch.tapCount == 2)
            {
                return true;
            }
        }

        return false;
    }

    public static float GetTouchZoom()
    {
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);
            Vector2 firstTouchDelta = firstTouch.position - firstTouch.deltaPosition;
            Vector2 secondTouchDelta = secondTouch.position - secondTouch.deltaPosition;

            float oldTouchDistance = Vector2.Distance(firstTouchDelta, secondTouchDelta);
            float currentTouchDistance = Vector2.Distance(firstTouch.position, secondTouch.position);

            return oldTouchDistance - currentTouchDistance;
        }

        return 0;
    }
}
