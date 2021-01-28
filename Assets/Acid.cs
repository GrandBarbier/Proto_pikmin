using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    public Victory victory;

    public MultipleTargetCam targetsCam;
    
    
    private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Player")
       {
           victory.targets.Remove(other.gameObject);
           targetsCam.targets.Remove(other.transform);
           Destroy(other.gameObject);
       }
   }
}
