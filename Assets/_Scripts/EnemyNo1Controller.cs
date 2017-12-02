using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS TIED TO ENEMYNO1 PREFAB

public class EnemyNo1Controller : MonoBehaviour {

	// Speed
	float speedOfEnemy;

	// Use this for initialization
	void Start () {

		speedOfEnemy = 2f;
		
	}

	// --- Collision Checking ---
	// Documentation:
	// https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
	public void OnCollisionEnter2D(Collision2D collision) {

		Debug.Log ("OnCollisionEnter2D() called.");
		//Debug.Log ("Collision check: " + collision.gameObject.tag == "PlayerFire");

		if (collision.gameObject.tag == "PlayerFire" ||
			collision.gameObject.tag == "PlayerFire(Clone)" ||
			collision.gameObject.name == "PlayerFire(Clone)" || 
		    collision.gameObject.name == "PlayerFire (clone)" || 
		    collision.gameObject.name == "PlayerFire" ||
			collision.gameObject == GameObject.FindGameObjectWithTag("PlayerFire") || 
			collision.gameObject == GameObject.FindGameObjectWithTag("PlayerFire(Clone)"))
		
		{
			Debug.Log ("ROGER! Collision EnemyNo1 with PlayerFire");
			//Debug.Log ("Collision check: " + collision.gameObject.tag == "PlayerFire");
			Destroy (gameObject);
		}

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
