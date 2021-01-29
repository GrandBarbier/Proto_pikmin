using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(Camera))]
public class MultipleTargetCam : MonoBehaviour
{
    public List<Transform> targets;

    public Vector3 offset;

    private Vector3 velocity;
    public float smoothTime = 0.5f;

    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimit = 50f;
    private Camera cam;

    public int maxPlayer;
   // public int actualPlayer;
    public TextMeshProUGUI maxPlayerText;
    public TextMeshProUGUI actualPlayerText;
    
    
    private void Start()
    {
        maxPlayer = 0;
        
        cam = GetComponent<Camera>();
        
        foreach (GameObject players in GameObject.FindGameObjectsWithTag("Player") )
        {
            targets.Add(players.transform);
            maxPlayer += 1;
        }
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (targets.Count == 0)
        {
            return;
        }
        
        maxPlayerText.text = maxPlayer.ToString();
        actualPlayerText.text = targets.Count.ToString();
        
        Move();

        Zoom();
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimit);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
    }

    void Move()
    {
         
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }
    
    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x + bounds.size.z;
    }

    Vector3 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;

        }
        
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }
}
