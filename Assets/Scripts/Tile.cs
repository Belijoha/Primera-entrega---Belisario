using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    float timeStood = 0f;
    private GameObject player;
    Vector3 startposition;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        transform.position = startposition;
      
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            timeStood += Time.deltaTime;
            if (timeStood > 3) 
                GetComponent<Rigidbody>().useGravity = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            GetComponent<Rigidbody>().useGravity = false;
            transform.position = startposition;
        }
    }
}
