using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundFishMovement : MonoBehaviour
{
    [SerializeField] private float teleportX = 8f;
    [SerializeField] private float positionX = -12f;
    [SerializeField] private int Swimspeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Swimspeed * Time.deltaTime);

        transform.Translate(Vector3.left * Swimspeed * Time.deltaTime, Space.World);

        if (transform.position.x <= positionX)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = teleportX;
            transform.position = newPosition;
        }
    }
}
