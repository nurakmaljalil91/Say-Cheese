using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonScript2 : MonoBehaviour {

	public int price;
	public GameObject areYouSurePanel;
	private int currentPlayerGold;

	private Text priceText;
	// Use this for initialization
	void Start () {
		priceText = transform.GetChild(0).GetComponent<Text>();
		priceText.text = price.ToString();

		// currentPlayerGold = 1000;
		//price = 450;
	}
	
	// Update is called once per frame
	void Update () {
		currentPlayerGold = PlayerPrefs.GetInt("Gold");
	}

	public void Buy(){
		if(currentPlayerGold >= price){
			areYouSurePanel.SetActive(true);
		}

		areYouSurePanel.GetComponent<AreYouSurePanelScript>().price = price;
		areYouSurePanel.GetComponent<AreYouSurePanelScript>().buyButton = this.gameObject;
	}
}
