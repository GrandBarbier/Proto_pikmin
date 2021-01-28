using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
    [SerializeField, Range(0.0f, 360f)] 
    private float angle = 90f;
    
    [SerializeField, Range(0.0f, 5f)] 
    private float speed = 2f;
    
    [SerializeField, Range(0.0f, 5f)] 
    private float startTime = 0f;
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
