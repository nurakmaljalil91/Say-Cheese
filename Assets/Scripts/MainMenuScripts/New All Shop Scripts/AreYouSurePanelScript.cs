using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouSurePanelScript : MonoBehaviour {

	public int price;

	private int currentPlayerGold;

	public GameObject buyButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ConfirmBuy(){
		
		currentPlayerGold = PlayerPrefs.GetInt("Gold");
		currentPlayerGold -= price;
		PlayerPrefs.SetInt("Gold", currentPlayerGold);
		PlayerPrefs.SetInt(buyButton.transform.name, 1); 
		Destroy(buyButton.gameObject);
	}
}
