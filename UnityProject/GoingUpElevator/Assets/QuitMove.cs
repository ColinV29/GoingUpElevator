using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMove : MonoBehaviour
{
    void Start()
    {
        transform.LeanMoveLocal(new Vector2(509, -783), 6);
    }
}
