using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class LeftDoorManager : MonoBehaviour
{
    public Animator LeftDoorAnimator;
    public void Openleftdoor()
    {
        LeftDoorAnimator.SetBool("Open", true);
        Debug.Log("Left door open Animation Played");
    }

    public void Closeleftdoor()
    {
        LeftDoorAnimator.SetBool("Open", false);
        Debug.Log("Left door open Animation Played");
    }

}
