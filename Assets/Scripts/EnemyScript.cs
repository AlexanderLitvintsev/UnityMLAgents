﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private WeaponScript weapon;

	private bool canBeDesytroyed = false;

	void Start () {

		GetComponent<Collider2D>().enabled = false;

		weapon = GetComponent<WeaponScript> ();	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (weapon != null && weapon.shootCooldown <= 0) 
		{
			weapon.Attack();

            // Shooting Sound of the Enemy
            SoundEffectScript.Instance.MakeEnemyShotSound();
		}

		if (GetComponent<Renderer>().IsVisibleFrom(Camera.main))
		{
			GetComponent<Collider2D>().enabled = true;

			canBeDesytroyed = true;
		}
		else
		{
			if (canBeDesytroyed)
			{
				Destroy(gameObject);

            }

		}
	}
}
