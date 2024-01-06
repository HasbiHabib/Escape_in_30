using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global.Audio;

public class BGMSetter : MonoBehaviour
{
    public string BGMName;
    public bool SetWhenAwake;

    private void Awake()
    {
        if (SetWhenAwake) 
        {
            SetMusic();
        }
    }
    public void SetMusic() 
    {
        FindObjectOfType<AudioManager>().SetCurrentBgmClip(BGMName);
    }
}
