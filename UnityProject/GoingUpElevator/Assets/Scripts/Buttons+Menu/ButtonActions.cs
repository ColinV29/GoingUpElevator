using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    public int Doorstate = 1;
    
    void Start()
    {
        Doorstate = 0;
        Door1.SetActive(true);
        Door2.SetActive(true);
    }
    public void UpButtonMethod()
    {
        Debug.Log("Up Pressed!");
    }

    public void DownButtonMethod()
    {
        Debug.Log("Down Pressed!");
    }

    public void OpenButtonMethod()
    {
        
    }

    public void CloseButtonMethod()
    { 
    
    }
}
