using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementsRb : MonoBehaviour
{
    private Rigidbody rb;
    
    private Vector3 inputs = Vector3.zero;

    public float speed = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        inputs = Vector3.zero;
        inputs.x = Input.GetAxis("Horizontal");
        inputs.z = Input.GetAxis("Vertical");

        if (inputs != Vector3.zero)
        {
            transform.forward = inputs;
            rb.freezeRotation = true;
        }
        else
        {
            rb.freezeRotation = false;
        }
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + inputs * speed * Time.fixedDeltaTime);
    }
}
