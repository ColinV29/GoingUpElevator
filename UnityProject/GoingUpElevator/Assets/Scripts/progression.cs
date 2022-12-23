using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progression : MonoBehaviour
{
    //only one progression active
    private static progression _instance;
    public static progression instance;
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
    private int currentPass;
    public int getCurrentPass(){
        return currentPass;
    }
    public void advancePass(){
        currentPass++;
        return;
    }

    //establish position
    public enum position {
        bottom,
        middle,
        top,
    }
    public position currentPosition = position.middle;
    //transition coroutine
    public IEnumerator GoingUp() {
        Debug.Log("Going Up from " + currentPosition);
        
        yield return new WaitForSeconds(7);

        switch(currentPosition){
            case position.bottom:
                currentPosition = position.middle;
                break;
            case position.middle:
                currentPosition = position.top;
                break;
            case position.top:
                Debug.Log("bruh you're in the backrooms");
                break;
        }
        Debug.Log("Arrived at " + currentPosition);
        advancePhase();
    }
}
