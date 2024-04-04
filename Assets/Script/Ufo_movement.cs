using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_movement : MonoBehaviour
{

    Rigidbody MyclassRigidbody;
    public float acc = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        MyclassRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
        MyclassRigidbody.AddForce(0f,0f, acc);
            Debug.Log("W key was pressed");
    }

          if (Input.GetKey(KeyCode.S)) {
            Debug.Log("S key was pressed");
            MyclassRigidbody.AddForce(0f,0f,-acc);
        }

         if (Input.GetKey(KeyCode.A)) {
            Debug.Log("A key was pressed");
           MyclassRigidbody.AddForce(-acc,0f,0f);
        }

         if (Input.GetKey(KeyCode.D)) {
            Debug.Log("D key was pressed");
           MyclassRigidbody.AddForce(acc,0f,0f);
        }
         if (Input.GetKey(KeyCode.Q)) {
            Debug.Log("Q key was pressed");
           MyclassRigidbody.AddForce(0f,-acc,0f);
        }
        if (Input.GetKey(KeyCode.E)) {
            Debug.Log("E key was pressed");
           MyclassRigidbody.AddForce(0f,acc,0f);
        }
        if (Input.GetKey(KeyCode.X)) {
            Debug.Log("X key was pressed brake!");
           MyclassRigidbody.AddForce(0f,0f,0f);
        }

    }
}
