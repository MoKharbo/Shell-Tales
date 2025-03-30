using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worldborder : MonoBehaviour
{
    private void Awake()
    {
        var bounds = GetComponent<SpriteRenderer>().bounds;
        Global.WorldBounds = bounds;
    }
}
