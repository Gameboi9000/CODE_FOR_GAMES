using UnityEngine;

public class LightMoving : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 xPos = startingPosition;

        xPos.x += distanceToCover * Mathf.Cos(Time.time * speed);

        transform.position = xPos;


    }
}
