using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public Transform hazard_0,hazard_2, hazard_4, hazard_6;     
    
    Vector3 startPos; //inital position of the player

    void Start()
    {
        startPos = transform.position; //able to store the inital position startPos 
    }

    void Update()
    {

//creating a hazard by making a class and then 
//referencing it here to automatically update in any position

            //player positions is checking if the cube Hazard_0 is true
        if (transform.position == hazard_0.position) {
            Debug.Log("I'm in the position -HAZARD_0");
            transform.position = startPos; //When we are at the hazard update the position
        }

         else if (transform.position == hazard_2.position) {
            Debug.Log("I'm in the position -HAZARD_2");
            transform.position = startPos; 
        }
        else if (transform.position == hazard_4.position) {
            Debug.Log("I'm in the position -HAZARD_4");
            transform.position = startPos; 
        }
        else if (transform.position == hazard_6.position) {
            Debug.Log("I'm in the position -HAZARD_6");
            transform.position = startPos; 
        }
    
    }
    }


