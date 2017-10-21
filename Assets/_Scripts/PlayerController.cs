using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// PUBLIC PROPERTIES 

	public float LeftBoundary;
	public float RightBoundary;

	//The Player Fire prefab. This prefab is attached to the "blue" pic in /Sprites folder.
	public GameObject playerFirePrefab;
	//Player Fire prefab's spawn point is called fire spot.
	public GameObject playerFireSpot;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	//**************************BOUNDARY + POSITION Setting**************************
	//*******************************************************************************
	//
	// 1. Set boundary limiting Player to only lft to right movement. 
	// 2. Set position of Player according to mouse movement.

			// 1. BOUNDARY
			//Position of x.
		    //(Mouse)
			float mouseX = Camera.main.ScreenToWorldPoint (Input.mousePosition).x;

			Vector3 mousePosition = new Vector3(mouseX, -200f, 0f);

			if (mousePosition.x > this.RightBoundary) {
				mousePosition.x = this.RightBoundary;
			}

			if (mousePosition.x < this.LeftBoundary) {
				mousePosition.x = this.LeftBoundary;
			}

				// 2. POISITION
				// Player position set to mouse position per frame:
				transform.position = mousePosition; 




		//****************************FIRE***************************
		//***********************************************************
		//
		//Fire on User keybutton press (space bar).
		//

			if (Input.GetKeyDown ("space")) {

				//FIRE!

				//Create fire prefab
				GameObject fire = (GameObject)Instantiate(playerFirePrefab);
				fire.transform.position = playerFireSpot.transform.position;

			}


	}
}
