using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

	//speed of fire
	float speedOfFire;

	// Use this for initialization
	void Start () {

		speedOfFire = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {

		//Get current position of fire
		Vector2 currentPosition = transform.position;

		//Compute fire's new position
		currentPosition = new Vector2 (currentPosition.x, currentPosition.y + speedOfFire + Time.deltaTime);

		//Update fire's position
		transform.position = currentPosition;

		//Remove fire from memory if it goes out of screen on top.....

			//Top of screen
			Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1,1));

			if (transform.position.y > max.y) {
				Destroy (gameObject);
			}
		
	}
}
