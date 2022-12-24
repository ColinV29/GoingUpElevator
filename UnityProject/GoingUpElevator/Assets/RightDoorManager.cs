using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoorManager : MonoBehaviour
{
    public Animator RightDoorAnimator;
    public void Openrightdoor()
    {
        RightDoorAnimator.SetBool("Openright", true);
        Debug.Log("Left door open Animation Played");
    }

    public void Closerightdoor()
    {
        RightDoorAnimator.SetBool("Openright", false);
        Debug.Log("Left door open Animation Played");
    }

}
