using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    public int Doorstate = 0;
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
        if (Doorstate == 0)
        {
            Debug.Log("Open Pressed!");
            Door1.SetActive(false);
            Door2.SetActive(false);
            Debug.Log("Door then Opened");
            Doorstate = 1;
            Debug.Log("Door state 1");
        }
        
        else
        {
            Debug.Log("Closed Pressed!");
            Door1.SetActive(true);
            Door2.SetActive(true);
            Debug.Log("Door then Closed");
            Doorstate = 0;
            Debug.Log("Door state 0");

        }
    }
}
