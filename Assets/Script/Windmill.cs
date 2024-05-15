using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : MonoBehaviour
{
    public Vector3 Windmillspeed;
    //Added vector 3 to target position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rotating the bees
     transform.Rotate(Windmillspeed);  
    }
}
