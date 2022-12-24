using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGlow : MonoBehaviour
{
    public progression progression;
    protected bool on;
    public ChangeMaterial upGlow;
    void Awake()
    {
        TurnOff();
    }
    void Update()
    {
        if (progression.currentPhase == progression.gameState.Departing && progression.buttonsActive){
            if (!on) {
                TurnOn();
            }
        }
        else if (progression.currentPhase == progression.gameState.Return && progression.getNextPass() && progression.buttonsActive) {
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
        upGlow.Go_green();
    }
    public void TurnOff() {
        on = false;
        upGlow.Go_Null();
    }
}
