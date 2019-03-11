using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NPCMovement : MonoBehaviour {

	private enum STATE {idle, moving};
	private STATE state;
	public Text randomPositionText;

	public Text positionInArray;

	// Nav Mesh agent of the npc
	private NavMeshAgent agent;

	// target for the npc to moveS
	// maybe inside the array random location
	private Transform target;

	private int randomNumber;

	public GameObject randomLocation;

	private Transform[] randomLocationPosition;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		// Init the random location	
		InitRandomLocation();

		// Init the state as idle
		state = STATE.idle;
		
	}
	
	// Update is called once per frame
	void Update () {

		// TODO: Check the state of the npc
		// if it not moving it will start generate the random number
		if(state == STATE.idle){
			// if it moving no need to generate random number
		// TODO: get random number
			randomNumber = GenerateRandomNumber();
		
		}
		
		
		// get random location
		ChooseTheLocation();
		// move to the random location
		//FIXME: movement is weird
		MoveToTarget();

		DebugRandomPositionText();
	}

	// generate the random number
	int GenerateRandomNumber(){
		int randomNumber = Random.Range(0, 6);

		return randomNumber;
	}


	void InitRandomLocation(){

		randomLocationPosition = new Transform[randomLocation.transform.childCount];

		for(int i = 0; i < randomLocation.transform.childCount; i++){
			randomLocationPosition[i] = randomLocation.transform.GetChild(i).transform;
		}
	}

	void ChooseTheLocation(){
		target = randomLocationPosition[GenerateRandomNumber()];
	}

	void MoveToTarget(){
		agent.SetDestination(target.position);
	}

	void DebugRandomPositionText(){
		randomPositionText.text = "NPC position: " + target.position.ToString();
	}

}
