using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public Transform hazard_0,hazard_1, hazard_3, hazard_5,hazard_2, hazard_4, hazard_6, boardHazard_0, winningTile;     
    
    Vector3 startPos; //here I am creating the Vector3 and storing it in a variable
    void Start()
    {
        startPos = transform.position; //I am updating the variable to the players position
        Debug.Log("Player position: StartInitalPos:" + startPos);
    }

    void Update()
    {

//creating a hazard by making a class and then 
//referencing it here to automatically update in any position

            //player positions is checking if the cube Hazard_0 is true
        if (transform.position == hazard_0.position) {
            Debug.Log("I'm in the position -HAZARD_0" + "startPos =" + startPos);
            transform.position = startPos; //In order to update the variable we must store it and then update it
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
            Debug.Log("I'm in the position -HAZARD_6  + startPos:+");
            transform.position = startPos; 
        }
         else if (transform.position == hazard_1.position) {
            Debug.Log("I'm in the position -HAZARD_1  + startPos:+");
            transform.position = startPos; 
        }
         else if (transform.position == hazard_3.position) {
            Debug.Log("I'm in the position -HAZARD_3  + startPos:" + startPos);
            transform.position = startPos; 
        }
         else if (transform.position == hazard_5.position) {
            Debug.Log("I'm in the position -HAZARD_5 position:" + hazard_5.position);
            transform.position = startPos; 
        }

        else if(transform.position == boardHazard_0.position) {
            Debug.Log("I'm on the BoardHazard_0 position, Will do something bad soon");
            transform.position = startPos;
        }
        else if(transform.position == winningTile.position) {
            Debug.Log("I'm on the winning tile position, will go to the next level soon");

        }
        
    
    
    }
    }


