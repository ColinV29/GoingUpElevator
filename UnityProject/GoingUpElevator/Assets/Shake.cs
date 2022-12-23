using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public AudioSource hum, bing;

    public IEnumerator Shaking(float duration) {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;
        hum.Play();


        while (elapsedTime < duration) {
                elapsedTime += Time.deltaTime;
                transform.position = startPosition + Random.insideUnitSphere * .0008f;
                yield return null;
        }

        transform.position = startPosition;
        bing.Play();
    }

}
