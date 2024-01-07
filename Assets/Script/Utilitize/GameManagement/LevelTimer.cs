using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public float MaxTime;
    public float Timer;
    public bool TimerOn;
    public Text TImeUI;
    public Animator PopupTime;

    void Start()
    {
        StartTheCount();
    }

    public void StartTheCount()
    {
        Timer = MaxTime;
        TimerOn = true;
    }

    public void StopCounting()
    {
        TimerOn = false;
    }

    void Update()
    {
        TImeUI.text = ((int)Timer) + "s";
        if (TimerOn)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                TimerOn = false;
            }
        }
    }

    public void ResetTimer()
    {
        Timer = MaxTime;
        PopupTime.SetTrigger("reset");
        TimerOn = true;
    }
}
