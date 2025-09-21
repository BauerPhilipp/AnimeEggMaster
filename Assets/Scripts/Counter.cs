using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] int targetMinutes = 2;
    [SerializeField] int targetSeconds = 45;

    [SerializeField] Transform minutes;
    [SerializeField] Transform seconds;

    float totalSeconds = 0;
    int totalMinutes = 0;
    




    bool isRunning = false;

    private void Start()
    {
        isRunning = true;
    }

    private void Update()
    {
        SetCounter();
    }

    private void SetCounter()
    {
        if (isRunning)
        {
            totalSeconds += Time.deltaTime;
            seconds.localRotation = Quaternion.Euler(0, 0, totalSeconds * (-30f / 5));
            if (totalSeconds >= 60)
            {
                totalMinutes += 1;
                totalSeconds = 0;
                seconds.localRotation = Quaternion.Euler(0, 0, 0);
                minutes.localRotation *= Quaternion.Euler(0, 0, -35f);
            }
            if (totalMinutes >= targetMinutes && totalSeconds >= targetSeconds)
            {
                isRunning = false;
            }
        }
    }

}

