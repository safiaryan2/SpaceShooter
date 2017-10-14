using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// PUBLIC PROPERTIES 

	public float LeftBoundary;
	public float RightBoundary;

	//fire prefab + fire position 1
	public GameObject firePrefab;
	public GameObject firePosition1;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		// POSITION + BOUNDARY setting...................................................

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


		//Fire on User keybutton press (space bar).....................................

		if (Input.GetKeyDown ("space")) {

			//Create fire
			GameObject fire = (GameObject)Instantiate(firePrefab);
			fire.transform.position = firePosition1.transform.position;

		}


	}
}
