using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {

    public float levelTime;
	// Use this for initialization
	void Start () {
        // Creatte Timer
        levelTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        levelTime += Time.deltaTime;

        //Debug.Log("Time : " + levelTime + "s");
	}
}
