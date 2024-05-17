using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    void Start()
    {
       
    }

// Update is called once per frame
    void Update()
    {
                             //movement of the player only 
        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("W key was pressed");
            transform.position += new Vector3(0f,0f,-1f); 
        }

          if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("S key was pressed");
            transform.position += new Vector3(0f,0f,1f);
        }

         if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("A key was pressed");
            transform.position += new Vector3(1f,0f,0f);
        }

         if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("D key was pressed");
            transform.position += new Vector3(-1f,0f,0f);
        }

    }
}
