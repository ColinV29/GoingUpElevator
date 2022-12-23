using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startmove : MonoBehaviour
{
    void Start()
    {
        transform.LeanMoveLocal(new Vector2(560, -665), 4);
    }
}
