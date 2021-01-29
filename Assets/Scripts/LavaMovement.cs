using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    public Renderer lava;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        lava = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.deltaTime * this.speed;
        lava.material.mainTextureOffset = new Vector2(offset,0f);
    }
}
