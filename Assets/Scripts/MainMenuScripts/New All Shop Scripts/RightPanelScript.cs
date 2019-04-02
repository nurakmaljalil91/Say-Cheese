using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPanelScript : MonoBehaviour {

	public GameObject accessoryPanel01;

	public GameObject accessoryPanel02;
	
	public void NextAccessoryPanel(){
		accessoryPanel01.SetActive(false);
		accessoryPanel02.SetActive(true);
	}
}
