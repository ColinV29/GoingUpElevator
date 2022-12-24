using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItUpButton : MonoBehaviour
{
    //all the up dialogue
    public UnityEvent pass1Up = new UnityEvent();
    public UnityEvent pass2Up = new UnityEvent();
    public UnityEvent pass3Up = new UnityEvent();
    public UnityEvent pass4Up = new UnityEvent();
    public UnityEvent pass5Up = new UnityEvent();
    public UnityEvent pass6Up = new UnityEvent();
    public UnityEvent pass7Up = new UnityEvent();
    public UnityEvent pass8Up = new UnityEvent();
    public Animator UpbuttonAnim;
    public GameObject Upbutton;
    public Shake cam;
    public progression progression;
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
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject && progression.buttonsActive)
            {
                Upbuttonpushed();
                DeterminePass();
            }
        }
    }

    public void DeterminePass() {
        if (progression.currentPhase == progression.gameState.Departing) {
            if (progression.getCurrentPass() == 1) {
                pass1Up.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2Up.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3Up.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4Up.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5Up.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6Up.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7Up.Invoke();
            }
            if (progression.getCurrentPass() == 8 && progression.confirm == false) {
                pass8Up.Invoke();
                progression.confirm = true;
                return;
            }
            progression.advancePhase();
            progression.StartCoroutine(progression.GoingUp());
            cam.StartCoroutine(cam.Shaking(7));
        }
        else if (progression.currentPhase == progression.gameState.Return && progression.getNextPass()) {
            progression.advancePhase();
            progression.StartCoroutine(progression.GoingUp());
            cam.StartCoroutine(cam.Shaking(7));
        }
    return;
    }

    public void Upbuttonpushed()
    {
        UpbuttonAnim.SetBool("Pushed", true);
        Debug.Log("Upbuttonanimated");
        Invoke("undoanim", 1f);
    }
    public void undoanim()
    {
        UpbuttonAnim.SetBool("Pushed", false);
    }

}
