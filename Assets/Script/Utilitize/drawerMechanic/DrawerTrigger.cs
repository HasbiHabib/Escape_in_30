using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DrawerTrigger : MonoBehaviour
{
    public KeyItem Keys;
    public UnityEvent UnlockCondition;

    private void Start()
    {
        Keys = FindObjectOfType<KeyItem>();
    }
    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OpenTheDrawer();
        }
    }

    public void OnMouseExit()
    {

    }

    public void OpenTheDrawer() 
    {
        if (Keys.KeyOn)
        {
            UnlockCondition.Invoke();
        }
        else 
        {
            Debug.Log("locked");
        }
    }
}
