using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRot : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //rb.AddForce(100,100,100);
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce((other.transform.position - transform.position )* 2000);
        }
        
    }
}
