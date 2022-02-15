using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlatform : MonoBehaviour
{
    public enum Platform { Rotate, FallDown};

    public Platform ActiveState = Platform.Rotate;
    private Falling platformFall;
    private Tile platformRotate;

    private void Start()
    {
        platformFall = GetComponent<Falling>();
        platformRotate = GetComponent<Tile>();
    }
    void Update()
    {
        switch (ActiveState)
        {
            case Platform.Rotate:
                platformRotate.enabled = true;
                platformFall.enabled = false;
                break;

            case Platform.FallDown:
                platformRotate.enabled = false;
                platformFall.enabled = true;
                break;
        }
    }
}