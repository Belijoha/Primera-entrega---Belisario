using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.1f;
    public Vector3 direction;
    public float timeDestroy;

    void Start()
    {
        if (gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject, timeDestroy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);

       
    }

     
}
