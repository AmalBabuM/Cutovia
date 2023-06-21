using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        RotateScreenVertical();
    }

    public void RotateScreenVertical()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    private void OnDisable()
    {
        RotateScreenHorizontal();
    }
    public void RotateScreenHorizontal()
    {
        Screen.orientation = ScreenOrientation.LandscapeRight;
    }
}
