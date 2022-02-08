using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 targetPosition;

    bool moveNext = true;
    public float timeToNext = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(6.5f, 0.66f, -5.6f);
        targetPosition = endPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (moveNext)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);

        }

        if (Vector3.Distance(transform.position, targetPosition)<=0)
        {
            StartCoroutine(TimeMove());
            if(targetPosition == endPosition)
            {
                targetPosition = startPosition;
            }
            else
            {
                targetPosition = endPosition;
            }
            


        }
    }
     IEnumerator TimeMove()
    {
        moveNext = false;
        yield return new WaitForFixedUpdate();
        moveNext = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "MaleFreeSimpleMovement1")
        {
            collision.collider.transform.SetParent(transform);
            Debug.Log("player hit: " + transform.name);
        }
    }

    void OnCollisionExit(Collision collison)
    {
        if (collison.gameObject.tag == "MaleFreeSimpleMovement1")
        {
            collison.collider.transform.SetParent(null);
            Debug.Log("player left: " + transform.name);
        }
    }
}
