using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoMove : MonoBehaviour
{
    void Start()
    {
        transform.LeanMoveLocal(new Vector2(712, -464), 3);
    }
}

