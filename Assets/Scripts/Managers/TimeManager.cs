using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    private float _slowMotionFactor = 0.1f;

    public void SetSlowMotion(bool isSlowMotion)
    {
        if (isSlowMotion)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = _slowMotionFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
        }
    }

}
