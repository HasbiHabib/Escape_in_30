using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public string number;
    public BrangkasManager brangkasManager;

    private void Start()
    {
        brangkasManager = FindObjectOfType<BrangkasManager>();
    }
    public void AddButton() 
    {
        brangkasManager.totalInput += number;
        brangkasManager.CheckCorrect();
    }

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AddButton();
        }
    }

    public void OnMouseExit()
    {

    }
}
