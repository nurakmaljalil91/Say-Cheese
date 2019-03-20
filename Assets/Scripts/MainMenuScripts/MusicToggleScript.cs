using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggleScript : MonoBehaviour {

	public GameObject audioManager;
    private AudioSource audioSource;
	public GameObject offImage;
	// Use this for initialization
	void Start () {
        audioSource = audioManager.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnChangeValue(){
		bool onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

		if(onOffSwitch){
            offImage.SetActive(false);
            audioSource.Play();
		}
		if(!onOffSwitch){
            //audioManager.GetComponent<AudioSource>()
            offImage.SetActive(true);
            audioSource.Pause();
			
		}
	}
	// public void OnChangeValue(){
	// 	bool onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

	// 	if(onOffSwitch){
	
	// 	}
	// 	if(!onOffSwitch){
			
	// 	}
	// }
}
