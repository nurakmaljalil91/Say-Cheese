using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanelScript : MonoBehaviour {

	private Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
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
