using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BrangkasManager : MonoBehaviour
{
    public string totalInput;
    public string thePassword;
    public UnityEvent UnlockEvent;

    public void CheckCorrect()
    {
        if(totalInput.Length >= 6) 
        {
            if(totalInput == thePassword) 
            {
                UnlockEvent.Invoke();
            }
            else 
            {
                Debug.Log("Meledak");
            }
        }
    }
}
