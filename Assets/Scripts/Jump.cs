using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private GameObject player;
    public float force = 2;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
       
            m_Rigidbody.AddForce(transform.up * force);
    }
}
