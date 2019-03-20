using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanelScript : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenPanel(){
		anim.SetBool("isOpen", true);
		anim.SetBool("isClose", false);
	}

	public void ClosePanel(){
		anim.SetBool("isOpen", false);
		anim.SetBool("isClose", true);
	}
}
