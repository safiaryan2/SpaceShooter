using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// PUBLIC PROPERTIES 

	public float LeftBoundary;
	public float RightBoundary;

	//The Fire prefab. This prefab is attached to the laser pic in /Sprites folder.
	public GameObject firePrefab;
	//Fire prefab's spawn point is called fire position 1
	public GameObject firePosition1;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//**************************POSITION + BOUNDARY Setting**************************
		//*******************************************************************************

			//Position of x.
		    //Mouse.
			float mouseX = Camera.main.ScreenToWorldPoint (Input.mousePosition).x;

			Vector3 mousePosition = new Vector3(mouseX, -200f, 0f);

			if (mousePosition.x > this.RightBoundary) {
				mousePosition.x = this.RightBoundary;
			}

			if (mousePosition.x < this.LeftBoundary) {
				mousePosition.x = this.LeftBoundary;
			}

			// Player position set to mouse position per frame:
			transform.position = mousePosition; 




		//****************************FIRE***************************
		//
		//Fire on User keybutton press (space bar)
		//
		//***********************************************************

		if (Input.GetKeyDown ("space")) {

			//Create fire prefab
			GameObject fire = (GameObject)Instantiate(firePrefab);
			fire.transform.position = firePosition1.transform.position;

		}


	}
}
