using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    
    private GameObject player;
    Vector3 startposition;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        startposition = transform.position;
        


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
           
            
            GetComponent<Rigidbody>().useGravity = true;
          
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            
            
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.position = startposition;
            GetComponent<Rigidbody>().isKinematic = true;
            
            GetComponent<Rigidbody>().useGravity = true;
            
        }
    }
}
