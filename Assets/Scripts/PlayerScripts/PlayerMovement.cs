using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	// speed of the player 
	public float speed = 10.0f;

	public Text positionText;

	// Controller for the player
	private CharacterController characterController;
	private Vector3 direction;
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		direction = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);
		characterController.Move(direction);
		DebugPositionText();
	}

	void DebugPositionText(){
		positionText.text = "Player Position :" + transform.position.ToString(); 
	}
}
