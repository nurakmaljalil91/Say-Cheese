using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerScript : MonoBehaviour
{

    public float levelTime;

    public float countdown = 10;

    public Text countdownText;
    
    // Use this for initialization
    void Start()
    {
        // Creatte Timer
        levelTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        levelTime += Time.deltaTime;
	countdown -= levelTime;
	if(countdown < 0){
		countdown = 0;
	}
	countdownText.text = countdown.ToString();
        //Debug.Log("Time : " + levelTime + "s");
    }
}
