using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour

    {
    Vector3 startPosition;
    public Vector3 endPosition;
    Vector3 targetPosition;

    bool moveNext = true;
    public float timeToNext = 4.0f;
    

    public float force = 2;
    

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        
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

        if (Vector3.Distance(transform.position, targetPosition) <= 0)
        {
            StartCoroutine(TimeMove());
            if (targetPosition == endPosition)
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

   
}
