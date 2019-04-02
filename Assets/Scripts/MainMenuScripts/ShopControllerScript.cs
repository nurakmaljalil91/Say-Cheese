using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopControllerScript : MonoBehaviour {
 
	public Text goldText;

	private int currentPlayerGold;

	
	// Use this for initialization
	void Start () {
		// PlayerPrefs.SetInt("Gold", 0);
	}
	
	// Update is called once per frame
	void Update () {
		CheckAndUpdatePlayerGold();
	}

	public void CheckAndUpdatePlayerGold(){
		currentPlayerGold = PlayerPrefs.GetInt("Gold");
		// currentPlayerGold = 100;
		goldText.text = "GOLD : "+ currentPlayerGold;

	}


	
}
