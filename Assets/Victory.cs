using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public MultipleTargetCam targetsCam;
    
    public List<GameObject> targets;
    
    public GameObject victory;
    public GameObject lose;
    
    
    public TextMeshProUGUI Score;

    public float score;
    public float scoreMin;
    
    void Start()
    {
        foreach (GameObject players in GameObject.FindGameObjectsWithTag("Player") )
        {
            targets.Add(players);
        }

        victory.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        score = score + 1;
        targets.Remove(other.gameObject);
        targetsCam.targets.Remove(other.transform);
        Destroy(other.gameObject);
    }
    
    void Update()
    {
        if (targets.Count <= 0)
        {
            victory.SetActive(true);
        }
        
        Score.text = "Score : " + score;
    }
    
}
