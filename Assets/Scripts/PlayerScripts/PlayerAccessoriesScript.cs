using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAccessoriesScript : MonoBehaviour {

	private int topHat;

	private int backpack;
	// Use this for initialization
	void Start () {
		// TODO: Player top hat will determine by the 
		// if zero so no items attached
		// maybe can use switch here
	
		topHat = 3;
		backpack = 1;
		for(int i = 0 ; i < gameObject.transform.childCount; i++){
			if( topHat == 1){
				if(transform.GetChild(i).name.Equals("bag01")){
					transform.GetChild(i).gameObject.SetActive(true);
				}	
			}
			if(topHat == 2){
				if(transform.GetChild(i).name.Equals("bag02")){
					transform.GetChild(i).gameObject.SetActive(true);
				}
			}
			if(topHat == 3){
				if(transform.GetChild(i).name.Equals("bag03")){
					transform.GetChild(i).gameObject.SetActive(true);
				}
			}
		}

		// for(int i = 0; i < )
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
