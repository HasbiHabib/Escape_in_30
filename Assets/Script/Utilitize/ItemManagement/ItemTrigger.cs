using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemTrigger : MonoBehaviour
{
    public UnityEvent InteractEvent;
    public UnityEvent Onmouse;
    public UnityEvent OutMouse;
    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Interact();
        }
        Onmouse.Invoke();
    }

    public void OnMouseExit()
    {
        OutMouse.Invoke();
    }

    public void Interact()
    {
        InteractEvent.Invoke();
    }
}
