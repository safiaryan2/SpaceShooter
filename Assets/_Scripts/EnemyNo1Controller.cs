using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS TIED TO ENEMYNO1 GAME OBJECT

public class EnemyNo1Controller : MonoBehaviour {

	// Speed
	float speedOfEnemy;

	// Use this for initialization
	void Start () {

		speedOfEnemy = 2f;
		
	}
	
	// Update is called once per frame
	void Update () {

		// 1. Send the Enemy down:

				//Get current position of enemy
				Vector2 currentPosition = transform.position;

				//Compute Enemy's new position
				currentPosition = new Vector2 (currentPosition.x, currentPosition.y - speedOfEnemy + Time.deltaTime);

				//Update Enemy's position
				transform.position = currentPosition;

		// 2. Remove Enemy from memory if it goes out of screen on top:

				//Bottom of screen
				Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2(0,0));

				if (transform.position.y < min.y) {
						Destroy (gameObject);
					}

	}
}
