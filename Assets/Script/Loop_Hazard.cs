using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_Hazard : MonoBehaviour
{
    // Start is called before the first frame update
 //board hazards
    public Transform[] hazards; 
    Vector3 startPos;


//audio
AudioSource AudioSource_HazardsHit; //first declare the class audioSource
public AudioClip Public_Class_AudioClip; //2nd step create the class AudioClip

   
    





    void Start()
    {   
    startPos = transform.position;
    AudioSource_HazardsHit = GetComponent<AudioSource>(); //getting the component in the object player
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < hazards.Length;i++) {

        if (transform.position == hazards[i].position) {
            Debug.Log("Hazard Ouch");
            transform.position = startPos;

            AudioSource_HazardsHit.PlayOneShot(Public_Class_AudioClip, 0.5f); //(audioclip, (float which is volume 0-1)

            }
    }
}
    
}


//To have a group of hazards, make an array. 
// first declar an array of hazards[]
//creating the loop first create the variable i and assign it, condition , check the size of the array, increment.
//is 1 less than 7 