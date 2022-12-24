using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progression : MonoBehaviour
{
    //only one progression active
    private static progression _instance;
    public static progression instance;
    public Animator cameraAnimator, creditsAnimator;
    void Awake()
    {
        if (_instance != null) Destroy (this);
        DontDestroyOnLoad(this);
        currentPass = 1;
    }

    //initiate the various game states
    public enum gameState {
        Waiting,
        Departing,
        Transit,
        Arrived,
        Return,
        Returning,
    }
    public gameState currentPhase = gameState.Waiting;
    public void advancePhase() {
        switch(currentPhase) {
            case gameState.Waiting:
                currentPhase = gameState.Departing;
                break;
            case gameState.Departing:
                currentPhase = gameState.Transit;
                break;
            case gameState.Transit:
                currentPhase = gameState.Arrived;
                break;
            case gameState.Arrived:
                currentPhase = gameState.Return;
                break;
            case gameState.Return:
                currentPhase = gameState.Returning;
                break;
            case gameState.Returning:
                currentPhase = gameState.Waiting;
                break;
        }
    }

    //establish current passenger and functions
    public int currentPass;
    public int getCurrentPass(){
        return currentPass;
    }
    public void advancePass(){
        currentPass++;
        advanceUps();
        return;
    }
/*
    //establish position
    public enum position {
        bottom,
        middle,
        top,
    }
    public position currentPosition = position.middle;
    */
    //transition coroutine
    public IEnumerator GoingUp() {
        wentUp = true;
        yield return new WaitForSeconds(7);
        advancePhase();
    }

    public IEnumerator GoingDown() {
        wentUp = false;
        yield return new WaitForSeconds(7);
        advancePhase();
    }

    protected bool[] goingUps = {true, false, true, false, true, true, false};
    protected bool nextPass = true;
    public bool wentUp = false;
    public void advanceUps() {
        nextPass = goingUps[currentPass - 1];
    }
    public bool getNextPass() {
        return nextPass;
    }

    public bool buttonsActive = false;
    public bool confirm = false;

    public void endGame(bool Up) {
        StartCoroutine(Credits());
    }

    public IEnumerator Credits() {
        cameraAnimator.SetBool("GameOver", true);
        yield return new WaitForSeconds(10);
        creditsAnimator.SetBool("GameOver", true);
        yield return new WaitForSeconds(10);
        Debug.Log("game done, go home");
    }
}
