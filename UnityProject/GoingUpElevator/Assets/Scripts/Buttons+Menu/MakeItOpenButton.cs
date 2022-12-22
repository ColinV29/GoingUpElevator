using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItOpenButton : MonoBehaviour
{
    public UnityEvent OpenEvent = new UnityEvent();
    public GameObject Openbutton;
    // Start is called before the first frame update
    void Start()
    {
        Openbutton = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            //check
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                OpenEvent.Invoke();
            }
        }
    }
}
