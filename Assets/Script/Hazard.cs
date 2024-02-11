using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public Transform hazard_0,hazard_1, hazard_3, hazard_5,hazard_2, hazard_4, hazard_6, boardHazard_0, winningTile, world_art;     
    
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
         else if (transform.position == hazard_1.position) {
            Debug.Log("I'm in the position -HAZARD_1");
            transform.position = startPos; 
        }
         else if (transform.position == hazard_3.position) {
            Debug.Log("I'm in the position -HAZARD_3");
            transform.position = startPos; 
        }
         else if (transform.position == hazard_5.position) {
            Debug.Log("I'm in the position -HAZARD_5");
            transform.position = startPos; 
        }

        else if(transform.position == boardHazard_0.position) {
            Debug.Log("I'm on the BoardHazard_0 position, Will do something bad soon");
            transform.position = startPos; 
        }
        else if(transform.position == winningTile.position) {
            Debug.Log("I'm on the winning tile position, will go to the next level soon");

        }
        else if(transform.position == world_art.position) {
            Debug.Log("player is interacting with world_art instance of the class hazard");

        }
    
    
    }
    }


