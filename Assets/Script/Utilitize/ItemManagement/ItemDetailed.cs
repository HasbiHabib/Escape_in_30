using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemDetailed : MonoBehaviour
{
    public GameObject Cameras;
    public UnityEvent CloseTrigger;
    public void ShowItem()
    {
        Cameras.SetActive(true);
        FindObjectOfType<gamemaster>().SetInteract(true);
        FindObjectOfType<ItemShowManager>().OpenedItemDetailed(this);
        FindObjectOfType<ItemShowManager>().ShowCloseButton();
    }
    public void CloseItem()
    {
        FindObjectOfType<gamemaster>().SetInteract(false);
        Cameras.SetActive(false);
        CloseTrigger.Invoke();
    }
}
