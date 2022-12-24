using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGlow : MonoBehaviour
{
    public progression progression;
    protected bool on;
    public ChangeMaterial leftWing, rightWing;
    void Awake()
    {
        TurnOff();
    }
    void Update()
    {
        if (progression.currentPhase == progression.gameState.Arrived && progression.buttonsActive){
            if (!on) {
                TurnOn();
            }
        }
        else if (progression.currentPhase == progression.gameState.Waiting && progression.buttonsActive) {
            if (!on) {
                TurnOn();
            }
        }
        else if (on) {
            TurnOff();
        }

    }
    public void TurnOn() {
        on = true;
        leftWing.Go_green();
        rightWing.Go_green();
    }
    public void TurnOff() {
        on = false;
        leftWing.Go_Null();
        rightWing.Go_Null();
    }
}
