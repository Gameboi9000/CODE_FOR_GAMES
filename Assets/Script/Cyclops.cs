using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{

   Rigidbody rb;
   public float explosionForce = 1f;
   public float explosionRadius = 100f;
   public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray laserBeam = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit = new RaycastHit(); //stores information what is hit

        if(Physics.Raycast(laserBeam, out hit) && Input.GetMouseButton(0) ) {
            Debug.Log("Cyclops sucks");
            if ( hit.rigidbody != null) 
            {
                hit.rigidbody.AddExplosionForce(explosionForce, hit.point, explosionRadius);
            }
        }
        

if(Physics.Raycast(laserBeam, out hit) && Input.GetMouseButton(1) ) {
        Instantiate(prefab, hit.point, Quaternion.identity);
}

    }
}


