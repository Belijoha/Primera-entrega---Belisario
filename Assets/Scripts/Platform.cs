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
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(6.5f, 0.66f, -5.6f);
        targetPosition = endPosition;
        player = GameObject.FindWithTag("Player");
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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
        }
    }
}
