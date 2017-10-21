using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS TIED TO FIRE PREFAB

public class PlayerFireController : MonoBehaviour {

	//speed of fire
	float speedOfFire;

	// Use this for initialization
	void Start () {

		speedOfFire = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {

		// 1. Send the Fire upwards:

				//Get current position of fire
				Vector2 currentPosition = transform.position;

				//Compute fire's new position
				currentPosition = new Vector2 (currentPosition.x, currentPosition.y + speedOfFire + Time.deltaTime);

				//Update fire's position
				transform.position = currentPosition;

		// 2. Remove Fire from memory if it goes out of screen on top.....

			//Top of screen
			Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1,1));

			if (transform.position.y > max.y) {
				Destroy (gameObject);
			}
		
	}
}
