using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    private Quaternion start, end;

    
    public float angle = 90f;
    
    
    public float speed = 2f;
    
    
    public float startTime = 0f;
    
    void Start()
    {
        start = PendulumRotation(angle);
        end = PendulumRotation(-angle);
        
    }

    
    void Update()
    {
        startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(start, end, (Mathf.Sin(startTime * speed + Mathf.PI / 2) + 1f) / 2f);
    }

    void ResetTimer()
    {
        startTime = 0;
    }
    
    
    
    

    Quaternion PendulumRotation(float pangle)
    {
        var pendulumRotation = transform.rotation;
        var angleZ = pendulumRotation.eulerAngles.z + pangle;
        
        if (angleZ > 180)
        {
            angleZ -= 360; 
        }
        else if(angleZ < -180)
        {
            angleZ += 360;
        }
        
        pendulumRotation.eulerAngles = new Vector3(pendulumRotation.eulerAngles.x, pendulumRotation.eulerAngles.y, angleZ);
        return pendulumRotation;
        
    }
}
