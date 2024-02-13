using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Movement : MonoBehaviour
{

public Transform Testing_Hazard;   

 Vector3 tempPos;
 float speed;
    void Start()
    {
 	//first store the position in a temporary variable
    	tempPos = transform.position;
    

    }

    void Update()
    {
//BOARD IS MADE ON 0,0,0 AXIS, BUT THE PLAYER IS ON 1,1,1 AXIS TO BE ABOVE THE BOARD, THE INTERACTION MUST BE ABOVE 
    	//axis on the board Z = 0-6 0 Is furthest to the right, 6 is the left end
    	// X = 0-5 , Y = up & down
    	if(transform.position == Testing_Hazard.position) {
    		tempPos.x =1 ;
    		tempPos.z =0;
    		tempPos.y =0;
    		transform.position = tempPos;

    	}
    }
}


