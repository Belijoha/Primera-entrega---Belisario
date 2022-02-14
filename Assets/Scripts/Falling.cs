using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float fallDelay = 3.0f;
    private GameObject player;
    


    void Start()
    {
        player = GameObject.FindWithTag("Player");
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
            
        }
    }

    IEnumerator FallAfterDelay()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody>().isKinematic = false;
        
    }
}
