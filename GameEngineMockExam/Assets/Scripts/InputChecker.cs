using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private float lastPressTime;
    private float multiplier = 1;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            float now = Time.time;
            if (now - lastPressTime <= 1f) multiplier += 0.1f;
            else multiplier = 1;

            lastPressTime = now;
            Spawner.Spawn(Mathf.CeilToInt(multiplier));
        }
    }
}
