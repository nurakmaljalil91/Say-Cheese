using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionManagerScripts : MonoBehaviour {


    [SerializeField] private GameObject[] levels;

    [SerializeField] private int currentLevel;

	// Use this for initialization
	void Start () {

        // PlayerPrefs.SetInt("level", 0); // for reset
        Debug.Log(PlayerPrefs.GetInt("level"));

        currentLevel = PlayerPrefs.GetInt("level");
        levels = new GameObject[transform.childCount];

	    for( int i = 0; i < transform.childCount; i++)
        {
            levels[i] = transform.GetChild(i).gameObject;
        }

        //Debug.Log("Current level: "+currentLevel);
        // loop here to check number of level unlock
        for(int i = 0; i < currentLevel; i++)
        {
            foreach(Transform unlock in levels[i].transform)
            {
                unlock.gameObject.SetActive(false);
            }
            levels[i].GetComponent<Button>().interactable = true;
        }

        	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
