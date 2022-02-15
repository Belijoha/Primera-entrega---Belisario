using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    private const float fallDelay = 0.5f;
    private const float fallBack = 2.0f;
    Vector3 startPosition;
    private GameObject player;
    


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        startPosition = transform.position;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            StartCoroutine(FallAfterDelay());
            
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            StartCoroutine(ReturnDelay());
        }
    }

    IEnumerator FallAfterDelay()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody>().isKinematic = false;


    }

    IEnumerator ReturnDelay()
    {
        yield return new WaitForSeconds(fallBack);
        transform.position = startPosition;
        GetComponent<Rigidbody>().isKinematic = true;


    }
}


