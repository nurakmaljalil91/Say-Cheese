using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingToggleButtonScript : MonoBehaviour {

	public GameObject settingPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnChangeValue(){
		bool onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

		if(onOffSwitch){
			//Debug.Log("Open Setting Panel");
			settingPanel.GetComponent<SettingPanelScript>().OpenPanel();
		}
		if(!onOffSwitch){
			//Debug.Log("Close Setting Panel");
			settingPanel.GetComponent<SettingPanelScript>().ClosePanel();
		}
	}

	
}
