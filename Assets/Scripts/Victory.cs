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
        lose.SetActive(false);
        
        targetsCam = Camera.main.gameObject.GetComponent<MultipleTargetCam>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            score = score + 1;
            other.gameObject.GetComponent<DeathManager>().Death();
        }
    }
    
    void Update()
    {
        if (targets.Count <= 0 && score > 0)
        {
            victory.SetActive(true);
        }
        else if (targets.Count <= 0)
        {
            lose.SetActive(true);
        }
        
        Score.text = "Score : " + score;
    }
}
