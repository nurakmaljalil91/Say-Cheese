using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollectCheese : MonoBehaviour {

	[SerializeField] private int NumberOfCheese;
	private Rigidbody rBody;

    private GameObject audioManager;

	public Text cheeseScoreText;

	// public GameObject winningPanel;

	// Use this for initialization
	void Start () {
		//rBody = GetComponent<Rigidbody>();
		audioManager = GameObject.FindGameObjectWithTag("AudioManager");
		NumberOfCheese = 0;
	}
	
	// Update is called once per frame
	void Update () {
		cheeseScoreText.text = "CHEESE : " + NumberOfCheese;
		// WiningTheLevel();
	}

	
	void OnTriggerEnter(Collider other){
		// Debug.Log(other.tag);
		if(other.tag.Equals("Cheese")){
            audioManager.GetComponent<AudioManagerScripts>().PlaySound("Eat");
            Destroy(other.gameObject);
            NumberOfCheese++;
		}
	}

	void WiningTheLevel(){
		if(NumberOfCheese >= 10){
			// winningPanel.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
