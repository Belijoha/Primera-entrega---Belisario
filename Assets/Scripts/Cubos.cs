using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour

    {
        public float BouncingForce = 2f;
        public Rigidbody PlayerBall;

        private void Start()
        {
            PlayerBall = gameObject.GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
                PlayerBall.AddForce(Vector3.up * BouncingForce);
        }
    }
