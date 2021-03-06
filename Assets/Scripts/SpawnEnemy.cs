﻿using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public Transform enemyPrefab;
	public float spawnRate = 2f; // float value = 2.0 seconds
	private bool isPositionPlayer = false;
	private Transform playerTransform;

	void Start () {

		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		InvokeRepeating ("Spawn", spawnRate, spawnRate);

	}

	private void Spawn() {

        isPositionPlayer = !isPositionPlayer;
 
		Vector3 spawnPosition;

		if (isPositionPlayer && playerTransform != null)
		{
			spawnPosition = new Vector3(playerTransform.position.x,
                                        transform.position.y,
		                            	transform.position.z);
            /*
            spawnPosition = new Vector3(playerTransform.position.x,
                                        transform.position.y,
                                        transform.position.z);
            */
        }
		else
		{

			spawnPosition = new Vector3(Random.Range(-4, 4), 
                                        transform.position.y,
			                            transform.position.z);
		}

		var enemyTransform = Instantiate (enemyPrefab) as Transform;

		enemyTransform.position = spawnPosition;
	}
}
