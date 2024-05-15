using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pan_back_forth : MonoBehaviour

{
  NavMeshAgent nav;
  public Transform start, end, current;
  public  float threshold = 1f;
    
 
    // Start is called before the first frame update
    void Start()
    {
      nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    if(nav.remainingDistance < threshold){
      if(start == current) {
        current = end;
      }

      else if( end == current) {
        current = start;
      }
      nav.SetDestination(current.position);
    }
    }
}
