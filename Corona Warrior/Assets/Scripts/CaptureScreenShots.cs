using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureScreenShots : MonoBehaviour
{
    private int shotIndex =0;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ScreenCapture.CaptureScreenshot($"Screenshot{shotIndex}.png");
            shotIndex++;
        }
    }
}
