using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawnerScript : MonoBehaviour {

	public GameObject[] npcs;

	private GameObject npc1;
	private GameObject npc2;
	private GameObject npc3;
	public Transform npcPositions1;
	public Transform npcPositions2;
	public Transform npcPositions3;
	// Use this for initialization
	void Start () {
		int randomNumber1 = Random.Range(0, npcs.Length - 1);
		npc1 = Instantiate(npcs[randomNumber1], npcPositions1.position, Quaternion.identity);

		int randomNumber2 = Random.Range(0, npcs.Length - 1);
		npc1 = Instantiate(npcs[randomNumber2], npcPositions2.position, Quaternion.identity);

		int randomNumber3 = Random.Range(0, npcs.Length - 1);
		npc1 = Instantiate(npcs[randomNumber3], npcPositions3.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
