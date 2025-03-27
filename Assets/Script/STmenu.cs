using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class AnimateSprite : MonoBehaviour
{
    [SerializeField]SpriteRenderer spriteRenderer;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }
 
    // Update is called once per frame
    void Update()
    {
        image.sprite = spriteRenderer.sprite;
    }
}