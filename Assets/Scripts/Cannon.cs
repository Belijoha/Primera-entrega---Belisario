using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
   
{
    public Transform ShootPosIni;
    public Transform Bullet;
    public float timeToShoot;
    private float timeToReset;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
          timeToReset = timeToShoot;
    }
    private void Temporizador()
    {
        timeToReset -= Time.deltaTime;

        if(timeToReset <= 0)

        {
            Shoot();
            ResetTimer();
        }    
    }
    // Update is called once per frame
    void Update()
    {
        
            Temporizador();
        

    }
    private void Shoot ()
    {
         Instantiate(Bullet,ShootPosIni.position, ShootPosIni.rotation);
    }

    
    
}
