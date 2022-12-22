using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItDownButton : MonoBehaviour
{
    public UnityEvent DownEvent = new UnityEvent();
    public GameObject Downbutton;
    // Start is called before the first frame update
    void Start()
    {
        Downbutton = this.gameObject;
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
                DownEvent.Invoke();
            }
        }
    }
}
