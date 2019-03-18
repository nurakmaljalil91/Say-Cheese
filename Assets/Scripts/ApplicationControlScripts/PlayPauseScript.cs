using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseScript : MonoBehaviour {

	void Start(){
		if(Time.timeScale == 0){
			Time.timeScale = 1;
		}
	}
	public void PauseTheGame(){
		Time.timeScale = 0;
	}

	public void PlayTheGame(){
		Time.timeScale = 1;
	}
}
