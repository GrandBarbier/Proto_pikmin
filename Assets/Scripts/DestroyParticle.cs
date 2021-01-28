using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    public float timer;
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(gameObject, timer);
    }
}
