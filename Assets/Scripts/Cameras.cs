using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{

    public GameObject cameraobj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            cameraobj.SetActive(!cameraobj.activeInHierarchy);
        }
        
        if(Input.GetKeyDown(KeyCode.F3))
        {
            cameraobj.SetActive(!cameraobj.activeInHierarchy);
        }

        if(Input.GetKeyDown(KeyCode.F4))
        {
            cameraobj.SetActive(!cameraobj.activeInHierarchy);
        }

        if(Input.GetKeyDown(KeyCode.F5))
        {
            cameraobj.SetActive(!cameraobj.activeInHierarchy);
        }
    }
}