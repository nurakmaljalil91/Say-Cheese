using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour {

	public GameObject cheeseLocation;

	public GameObject cheesePrefab;
	private GameObject cheese;

	private GameObject[] cheeseLocationInArray;



	private bool cheeseIsInMap;

	private Vector3 randomPosition;

	// Use this for initialization
	void Start () {
		InitTheArrayWithTheLocationOfCheese();
		cheeseIsInMap = false;
	}
	
	// Update is called once per frame
	void Update () {
		// check if there is a cheese in the map
		if(!cheeseIsInMap){
			// TODO: Generate the random position location
			GenerateRandomLocation();
			// TODO: we spawn the cheese in the random position
			SpawnTheCheese();
		
		}

		// TODO: Here is where we destroy the cheese and change the boolean
	}

	void InitTheArrayWithTheLocationOfCheese(){

		cheeseLocationInArray = new GameObject[transform.childCount]; 
		for(int i = 0; i < transform.childCount; i++){
			cheeseLocationInArray[i] = transform.GetChild(i).gameObject;
		}
	}

	void GenerateRandomLocation(){
		int randomNumber = Random.Range(0, transform.childCount);

		randomPosition = cheeseLocationInArray[randomNumber].transform.position;
	}

	void SpawnTheCheese(){

		// Instatiate the cheese
		cheese = Instantiate(cheesePrefab, randomPosition, Quaternion.identity);
		cheeseIsInMap = true;
	}

}
