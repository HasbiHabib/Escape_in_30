using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClockManager : MonoBehaviour
{
    public float HourKey;
    public float MinuteKey;

    public float CurrentHourKey;
    public float CurrentMinuteKey;

    public ClockNail Hour;
    public ClockNail Minute;

    private void FixedUpdate()
    {
        CurrentHourKey = Hour.CurrentNumber;
        CurrentMinuteKey = Minute.CurrentNumber;
    }

    public void CheckClock() 
    {
        if (CurrentHourKey != 0 && CurrentMinuteKey != 0)
        {
            if (CurrentHourKey % HourKey == 0 && CurrentMinuteKey % MinuteKey == 0)
            {
                Debug.Log("win");
            }
        }
    }
}
