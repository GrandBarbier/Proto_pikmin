using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    
    public float speedX = .5f;
    public float speedY = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.deltaTime * speedX;
        float offsetY = Time.deltaTime * speedY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
        //lava.material.mainTextureOffset = new Vector2(offset, 5);
    }
}
