using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetonatorTrigger : MonoBehaviour
{
    public UnityEvent pressedEvent;
    public bool rightButton; 

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pressedEvent.Invoke();
            if (rightButton) 
            {
                FindObjectOfType<DetonatorManager>().AddDetonator();
            }
        }
    }

    public void OnMouseExit()
    {

    }


}
