﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPowerUp : MonoBehaviour {

	
	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.tag.Equals("Candy")){
			// Speed of agent increase
			// agent.speed = 10;
			Destroy(other.gameObject);
			StartCoroutine(SpeedIncrease(15f));

		}
	}

	IEnumerator SpeedIncrease(float duration){
		Debug.Log("Speed Increase");
		agent.speed = 10;
		yield return new WaitForSeconds(duration);
		agent.speed = 3.5f;
		Debug.Log("Speed Decrease");
	}

	
}
