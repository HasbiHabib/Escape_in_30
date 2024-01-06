using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AudioData;

public class ClockNail : MonoBehaviour
{
    public ClockManager manager;
    public float CurrentNumber;

    public Transform TheNails;

    public float RotateGap;

    private void Start()
    {
        NailClicked();
    }
    public void NailClicked() 
    {  
        CurrentNumber += RotateGap;
        TheNails.rotation = Quaternion.Euler(CurrentNumber,0,0);
        manager.CheckClock();
    }

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            NailClicked();
        }
    }

    public void OnMouseExit()
    {

    }
}
