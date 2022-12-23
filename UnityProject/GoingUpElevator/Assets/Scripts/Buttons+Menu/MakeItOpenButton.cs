using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItOpenButton : MonoBehaviour
{
    public UnityEvent pass1In = new UnityEvent();
    public UnityEvent pass2In = new UnityEvent();
    public UnityEvent pass3In = new UnityEvent();
    public UnityEvent pass4In = new UnityEvent();
    public UnityEvent pass5In = new UnityEvent();
    public UnityEvent pass6In = new UnityEvent();
    public UnityEvent pass7In = new UnityEvent();
    public UnityEvent pass8In = new UnityEvent();
    //out events
    public UnityEvent pass1Out = new UnityEvent();
    public UnityEvent pass2Out = new UnityEvent();
    public UnityEvent pass3Out = new UnityEvent();
    public UnityEvent pass4Out = new UnityEvent();
    public UnityEvent pass5Out = new UnityEvent();
    public UnityEvent pass6Out = new UnityEvent();
    public UnityEvent pass7Out = new UnityEvent();
    public UnityEvent pass8Out = new UnityEvent();
    public GameObject Openbutton;
    public progression progression;
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
                DeterminePass();
            }
        }
    }
        public void DeterminePass() {
        if (progression.currentPhase == progression.gameState.Waiting) {
            if (progression.getCurrentPass() == 1) {
                pass1In.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2In.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3In.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4In.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5In.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6In.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7In.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8In.Invoke();
            }

            progression.advancePhase();
        }
        else if (progression.currentPhase == progression.gameState.Arrived) {
            if (progression.getCurrentPass() == 1) {
                pass1Out.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2Out.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3Out.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4Out.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5Out.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6Out.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7Out.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8Out.Invoke();
            }
        }
    }
}
