using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS TIED TO ENEMYNO1SPAWNER GAME OBJECT

public class EnemyNo1Spawner : MonoBehaviour {


	//The EnemyNo1 prefab. This prefab is attached to the enemy1 pic in /Sprites folder.
	public GameObject enemyNo1Prefab;

	// Use this for initialization
	void Start () {

		SpawnTimer ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// FUNCTION: Spawn (create) EnemyNo1 prefab randomly.
	void EnemeyNo1Spawner()
	{

		// 1. Set boundary:

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

		// 2. Create a new EnemyNo1.
		//    Randomly created on boundary set.

		GameObject enemyNo1 = (GameObject)Instantiate(enemyNo1Prefab);
		enemyNo1.transform.position = new Vector2 (Random.Range(min.x,max.x),max.y);
			

	}

	void SpawnTimer()
	{

		// Invoke Repeating - Calls a method every x number of seconds (float).
		// First 4 seconds for first call, and then 2nd 4 seconds for repeating calls.
		// https://docs.unity3d.com/ScriptReference/MonoBehaviour.InvokeRepeating.html
		InvokeRepeating("EnemeyNo1Spawner", 4f, 4f);

	}
		
}
