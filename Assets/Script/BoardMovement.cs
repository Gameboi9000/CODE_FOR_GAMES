using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("W key was pressed");
            transform.position += new Vector3(-0f,-0f,-1f);
        }

          if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("S key was pressed");
            transform.position += new Vector3(0f,0f,1f);
        }

         if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("Q key was pressed");
            transform.position += new Vector3(1f,0f,0f);
        }

         if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("E key was pressed");
            transform.position += new Vector3(-1f,0f,0f);
        }


    
    }
}
