using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteStarScript : MonoBehaviour {

    public LevelManagerScript levelManager;

    private float timeComplete;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public int unlockLevel;

    private bool checkTime = false;
	// Use this for initialization
	void Start () {
       
    }

  
    // Update is called once per frame
    void Update () {
        
        if (transform.gameObject.activeSelf)
        {
            //check the time complete
            checkTime = true;

        }

        if (checkTime)
        {
            timeComplete = levelManager.levelTime;
            PlayerPrefs.SetInt("level", unlockLevel);
            checkTime = false;
        }

    
        if(timeComplete > 180f && timeComplete < 400f)
        {
            // Get 1 Star
            star1.SetActive(true);
        }
        if(timeComplete >= 60f && timeComplete <= 179f)
        {
            // Get 2 Star
            star1.SetActive(true);
            star2.SetActive(true);
        }

        if(timeComplete < 59f)
        {
            // Get 3 Star
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
	}
}
