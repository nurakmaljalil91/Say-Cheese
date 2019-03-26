using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnerScript : MonoBehaviour {

	public GameObject playerPrefab;

	private GameObject player;
	// Use this for initialization
	void Start () {
		player = Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
