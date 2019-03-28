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
		

		currentPlayerGold -= price;

		Destroy(buyButton.gameObject);
	}
}
