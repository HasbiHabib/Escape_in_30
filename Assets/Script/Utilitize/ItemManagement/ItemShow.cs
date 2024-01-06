using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemShow : MonoBehaviour
{
    public Animator ItemPos;
    public UnityEvent CloseTrigger;
    public void ShowItem() 
    {
        FindObjectOfType<gamemaster>().SetInteract(true);
        ItemPos.SetBool("Show", true);
        FindObjectOfType<ItemShowManager>().OpenedItemShow(this);
        FindObjectOfType<ItemShowManager>().ShowCloseButton();
    }
    public void CloseItem()
    {
        FindObjectOfType<gamemaster>().SetInteract(false);
        ItemPos.SetBool("Show", false);
        CloseTrigger.Invoke();
    }
}
