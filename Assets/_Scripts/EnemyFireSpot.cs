using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS TIED TO ENEMYFIRESPOT PREFAB
// This is Enemy's fire spot. Will fire from here. Towards the player.

public class EnemyFireSpot : MonoBehaviour {

	// The Enemy Fire prefab. 
	// This prefab is attached to the "laser" pic in /Sprites folder.
	public GameObject enemyFirePrefab;


	// Use this for initialization
	void Start () {

		Invoke ("fireTowardsPlayer", 1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void fireTowardsPlayer(){

		//Get Player game object
		GameObject playerReference = GameObject.Find("Player");
		Debug.Log (playerReference);

		if (playerReference != null) {

			//FIRE!

			//Create fire prefab
			GameObject fire = (GameObject)Instantiate(enemyFirePrefab);


			fire.transform.position = transform.position;

			//Direction
			Vector2 direction = playerReference.transform.position - fire.transform.position;

			fire.GetComponent<EnemyNo1FireController>().setDirection(direction);

			// https://docs.unity3d.com/Manual/ControllingGameObjectsComponents.html
			// http://answers.unity3d.com/questions/1066056/problem-shoot-bullet-in-direction-of-player-c.html




		} 
			

	}


}
