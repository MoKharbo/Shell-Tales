using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundfish2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);

        transform.Translate(Vector3.right * Time.deltaTime, Space.World);
    }
}
