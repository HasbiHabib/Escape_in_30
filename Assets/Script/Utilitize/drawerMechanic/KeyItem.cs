using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public bool KeyOn;
    public GameObject KeyUI;
    
    public void GetKey(bool Fill) 
    {
        KeyOn = Fill;
        KeyUI.SetActive(Fill);
    }
}
