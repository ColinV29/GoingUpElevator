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
    //out at top events
    public UnityEvent pass1OutTop = new UnityEvent();
    public UnityEvent pass2OutTop = new UnityEvent();
    public UnityEvent pass3OutTop = new UnityEvent();
    public UnityEvent pass4OutTop = new UnityEvent();
    public UnityEvent pass5OutTop = new UnityEvent();
    public UnityEvent pass6OutTop = new UnityEvent();
    public UnityEvent pass7OutTop = new UnityEvent();
    public UnityEvent pass8OutTop = new UnityEvent();
    //out at bot events
    public UnityEvent pass1OutBot = new UnityEvent();
    public UnityEvent pass2OutBot = new UnityEvent();
    public UnityEvent pass3OutBot = new UnityEvent();
    public UnityEvent pass4OutBot = new UnityEvent();
    public UnityEvent pass5OutBot = new UnityEvent();
    public UnityEvent pass6OutBot = new UnityEvent();
    public UnityEvent pass7OutBot = new UnityEvent();
    public UnityEvent pass8OutBot = new UnityEvent();
    public UnityEvent Opendoor = new UnityEvent();
    public UnityEvent Closedoor = new UnityEvent();
    public GameObject Openbutton;
    public progression progression;
    public AudioSource doorNoise;
    public int door_state = 1;
    public Animator OpenbuttonAnim;
    // Start is called before the first frame update
    void Start()
    {
        Openbutton = this.gameObject;
        door_state = 1;
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
                Openbuttonpushed();
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
            Opendoor.Invoke();
            progression.buttonsActive = false;
            StartCoroutine(ShutDoor());
            doorNoise.Play();
        }
        else if (progression.currentPhase == progression.gameState.Arrived && progression.wentUp) {
            if (progression.getCurrentPass() == 1) {
                pass1OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7OutTop.Invoke();
                progression.advancePhase();
                progression.advancePhase();
                progression.advancePhase();
            }
            if (progression.getCurrentPass() == 8) {
                progression.endGame(true);
                Opendoor.Invoke();
                return;
            }
            progression.advancePhase();
            progression.advancePass();
            Opendoor.Invoke();
            progression.buttonsActive = false;
            StartCoroutine(ShutDoor());
            doorNoise.Play();
        }
        else if (progression.currentPhase == progression.gameState.Arrived && !progression.wentUp) {
            if (progression.getCurrentPass() == 1) {
                pass1OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7OutBot.Invoke();
                progression.advancePhase();
                progression.advancePhase();
                progression.advancePhase();
            }
            if (progression.getCurrentPass() == 8) {
                progression.endGame(false);
                Opendoor.Invoke();
                return;
            }
            progression.advancePhase();
            progression.advancePass();
            Opendoor.Invoke();
            progression.buttonsActive = false;
            StartCoroutine(ShutDoor());
            doorNoise.Play();
        }
    }
    public void Openbuttonpushed()
    {
        OpenbuttonAnim.SetBool("IsPuhed", true);
        Debug.Log("Openbuttonanimated");
        Invoke("undoanim", 1f);
    }
    public void undoanim()
    {
        OpenbuttonAnim.SetBool("IsPuhed", false);
    }
    

    IEnumerator ShutDoor() {
        yield return new WaitForSeconds(2.5f);
        Closedoor.Invoke();
        progression.buttonsActive = true;
        doorNoise.Play();
    }
}
