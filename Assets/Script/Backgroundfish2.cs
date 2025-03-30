using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundfish2 : MonoBehaviour
{
    [SerializeField] private float teleportX = -5f;
    [SerializeField] private float positionX = 16f;
    [SerializeField] private int Swimspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Swimspeed * Time.deltaTime);

        transform.Translate(Vector3.right * Swimspeed * Time.deltaTime, Space.World);

        if (transform.position.x <= positionX)
        {
            Vector3 newPosition1 = transform.position;
            newPosition1.x = teleportX;
            transform.position = newPosition1;
        }
    }
}
