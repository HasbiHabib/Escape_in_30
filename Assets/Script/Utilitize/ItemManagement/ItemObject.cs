using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemObject : MonoBehaviour
{
    public bool Ranged;
    public bool Onhighlight;

    public Animator ItemColor;
    public UnityEvent InteractEvent;
    public gamemaster _gm;

    public void Start()
    {
        _gm = FindObjectOfType<gamemaster>();
    }
    public void Onranged() 
    {
        Ranged = true;
        ItemColor.SetBool("Ranged", true);
    }

    public void OutRanged() 
    {
        Ranged = false;
        ItemColor.SetBool("Ranged", false);
        ItemColor.SetBool("highlight", false);
    }

    public void OnMouseOver() 
    {
        if (Ranged && _gm.OnInteract == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Interact();
            }
            ItemColor.SetBool("highlight", true);
        }
    }

    public void OnMouseExit() 
    {
         ItemColor.SetBool("highlight", false);
    }

    public void Interact() 
    {
        InteractEvent.Invoke();
    }
}
