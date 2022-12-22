using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItUpButton : MonoBehaviour
{
    public UnityEvent UpEvent = new UnityEvent();
    public GameObject Upbutton;
    // Start is called before the first frame update
    void Start()
    {
        Upbutton = this.gameObject;
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
                UpEvent.Invoke();
            }
        }
    }
}
