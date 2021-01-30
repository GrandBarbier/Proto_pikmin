using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
    
    public float angle = 90f;
    
   
    public float speed = 2f;
    
    
    public float startTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 10);
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
