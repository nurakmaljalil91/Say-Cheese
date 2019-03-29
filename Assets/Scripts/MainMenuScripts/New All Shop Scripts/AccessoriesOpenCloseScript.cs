using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessoriesOpenCloseScript : MonoBehaviour {

	private bool onOffSwitch;

	public GameObject accessoryPabel;

	private GameObject openAccessoryPanelImage;
	private GameObject closeAccessoryPanelImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		closeAccessoryPanelImage = transform.GetChild(0).gameObject;
		openAccessoryPanelImage = transform.GetChild(1).gameObject;
	}

	public void OnChangeValue(){
		onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

		if(onOffSwitch){
			openAccessoryPanelImage.SetActive(true);
			accessoryPabel.SetActive(true);
		}
		if(!onOffSwitch){
			openAccessoryPanelImage.SetActive(false);
			accessoryPabel.SetActive(false);
		}
	}
}
