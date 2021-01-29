using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public Victory victory;
    public MultipleTargetCam targetsCam;

    public GameObject explosion;

    public bool crushable;
    
    void Start()
    {
        victory = GameObject.Find("Checkpoint").GetComponent<Victory>();
        targetsCam = Camera.main.gameObject.GetComponent<MultipleTargetCam>();
    }


    public void Death()
    {
        victory.targets.Remove(gameObject);
        targetsCam.targets.Remove(gameObject.transform);

        Instantiate(explosion, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crush")
        {
            crushable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Crush" && crushable)
        {
            crushable = false;
        }
    }
}
