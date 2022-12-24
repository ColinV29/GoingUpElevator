using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingsmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LeanMoveLocal(new Vector2(526, -729), 5);
    }
}

