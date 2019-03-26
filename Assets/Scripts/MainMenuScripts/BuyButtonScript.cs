using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButtonScript : MonoBehaviour {

	public int price;

	private int currentPlayerGold;

	// Use this for initialization
	void Start () {
		// currentPlayerGold = 900;
		// price = 450;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CanBuy(){
		if(currentPlayerGold > price){
			currentPlayerGold -= price;
			// PlayerPrefs.SetInt("Gold",currentPlayerGold);
			Destroy(transform.gameObject);
		}
	}
}
