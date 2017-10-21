using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNo1FireController : MonoBehaviour {


	float speedOfFire;
	Vector2 directionOfFire;
	bool directionIsSet;


	// Awake() - Awake is used to initialize any variables or game state before the game starts. 
	// https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
	void Awake(){
		speedOfFire = 1f;
		directionIsSet = false;

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (directionIsSet) {


			// 1. Update Position:

			Vector2 currentPoisition = transform.position;

			currentPoisition = currentPoisition + directionOfFire * speedOfFire * Time.deltaTime;

			transform.position = currentPoisition;

			// 2. Remove Fire from memory if it goes out of screen:

				//Bottom Left of screen
				Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2(0,0));

				//Top Right of screen
				Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1,1));

				//Remove the object

					if (transform.position.x < min.x ||
						transform.position.x > max.x ||
						transform.position.y < min.y ||
						transform.position.y > max.y) {
							Destroy (gameObject);
						}

		} else {
		}
		
	}

	public void setDirection(Vector2 direction){

		directionOfFire = direction;

		directionIsSet = true;
	}

}
