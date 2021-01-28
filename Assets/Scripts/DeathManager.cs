using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public Victory victory;
    public MultipleTargetCam targetsCam;

    public GameObject explosion;
    
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
}
