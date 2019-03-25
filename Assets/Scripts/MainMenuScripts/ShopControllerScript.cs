using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopControllerScript : MonoBehaviour {
 
	public int totalGameGolds;

	[SerializeField] private GameObject[] items;
	// Use this for initialization
	void Start () {

		items = new GameObject[transform.childCount];

		for(int i = 0; i < transform.childCount; i++){
			items[i] = transform.GetChild(i).gameObject;

		}

		// This for testing so the game gold will be hundred
		totalGameGolds = 100;
		// totalGameGolds = PlayerPrefs.GetInt("Gold");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void BuyItem(){
		// Check if the money enough to buy the item
		// if enough the button will change to equip
		
	}
}
