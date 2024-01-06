using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShowManager : MonoBehaviour
{
    public ItemShow allItem;
    public ItemDetailed allItem2;

    public GameObject CloseButton;

    public void CloseAllitem() 
    {
        if(allItem != null) 
        {
            allItem.CloseItem();
        }
        if(allItem2 != null) 
        {
            allItem2.CloseItem();
        }

        CloseButton.SetActive(false);
        allItem = null;
        allItem2 = null;
    }

    public void OpenedItemShow(ItemShow b) 
    {
        allItem = b;
    }

    public void OpenedItemDetailed(ItemDetailed b)
    {
        allItem2 = b;
    }

    public void ShowCloseButton() 
    {
        CloseButton.SetActive(true);
    }
}
