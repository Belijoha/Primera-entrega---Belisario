using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 90.0f*Time.deltaTime, 0.0f, Space.Self);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            Destroy(gameObject);
        }
    }
}
