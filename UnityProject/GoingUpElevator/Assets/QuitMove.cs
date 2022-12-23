using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMove : MonoBehaviour
{
    void Start()
    {
        transform.LeanMoveLocal(new Vector2(511, -726), 5);
    }
}
