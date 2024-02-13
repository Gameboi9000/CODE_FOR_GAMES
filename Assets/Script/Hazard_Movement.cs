using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Movement : MonoBehaviour
{
    public Transform EnemyMovement_0;

    public float speed;

    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {  
        if(speed == 0)
        {
            transform.Translate(1,0,0);
        }

        
    }
}
