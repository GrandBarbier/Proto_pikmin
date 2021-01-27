using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public List<GameObject> targets;
    public Text victory;
    public Text Score;

    public float score;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject players in GameObject.FindGameObjectsWithTag("Player") )
        {
            targets.Add(players);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        score = score + 1;
        targets.Remove(other.gameObject);
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (targets.Count <= 0)
        {
            victory.enabled = true;
            Score.text = score.ToString();

        }
    }
}
