using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseScript : MonoBehaviour {

	public void PauseTheGame(){
		Time.timeScale = 0;
	}

	public void PlayTheGame(){
		Time.timeScale = 1;
	}
}
