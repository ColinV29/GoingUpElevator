using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItDownButton : MonoBehaviour
{
    public UnityEvent pass1Down = new UnityEvent();
    public UnityEvent pass2Down = new UnityEvent();
    public UnityEvent pass3Down = new UnityEvent();
    public UnityEvent pass4Down = new UnityEvent();
    public UnityEvent pass5Down = new UnityEvent();
    public UnityEvent pass6Down = new UnityEvent();
    public UnityEvent pass7Down = new UnityEvent();
    public UnityEvent pass8Down = new UnityEvent();
    public GameObject Downbutton;
    public Shake camera;
    public progression progression;
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
                DeterminePass();
            }
        }
    }

    public void DeterminePass() {
        if (progression.currentPhase == progression.gameState.Departing) {
            if (progression.getCurrentPass() == 1) {
                pass1Down.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2Down.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3Down.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4Down.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5Down.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6Down.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7Down.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8Down.Invoke();
            }
            progression.advancePhase();
            progression.StartCoroutine(progression.GoingDown());
            camera.StartCoroutine(camera.Shaking(7));
        }
        else if (progression.currentPhase == progression.gameState.Return && progression.currentPosition == progression.position.top) {
            progression.advancePhase();
            progression.advancePass();
            progression.StartCoroutine(progression.GoingDown());
            camera.StartCoroutine(camera.Shaking(7));
        }
    return;
    }
}
