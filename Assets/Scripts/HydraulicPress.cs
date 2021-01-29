using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraulicPress : MonoBehaviour
{
    public float speed = 2f;

    public bool goUp;

    public GameObject limitUp;
    public GameObject limitDown;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goUp)
        {
            transform.Translate(transform.up * speed);
        }
        else
        {
            transform.Translate(-transform.up * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == limitDown)
        {
            goUp = true;
        }
        else if(other.gameObject == limitUp)
        {
            goUp = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<DeathManager>().crushable)
        {
            other.gameObject.GetComponent<DeathManager>().Death();
        }
    }
}
