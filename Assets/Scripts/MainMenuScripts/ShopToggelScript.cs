using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopToggelScript : MonoBehaviour {

	public GameObject shopPanel;


	public void OnChangeValue(){
		bool onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

		if(onOffSwitch){
			shopPanel.GetComponent<ShopPanelScript>().OpenPanel();
		}
		if(!onOffSwitch){
			shopPanel.GetComponent<ShopPanelScript>().ClosePanel();
		}
	}
}
