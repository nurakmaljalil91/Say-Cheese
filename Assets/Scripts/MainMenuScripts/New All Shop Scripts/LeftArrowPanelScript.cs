using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowPanelScript : MonoBehaviour {

	// Use this for initialization
	public GameObject accessoryPanel01;
	public GameObject accessoryPanel02;
	
	public void ChangeAccessoryPanel(){
		accessoryPanel01.SetActive(true);
		accessoryPanel02.SetActive(false);
	}
}
