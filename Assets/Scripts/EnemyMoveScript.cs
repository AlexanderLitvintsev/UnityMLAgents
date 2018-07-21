using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour {


    // The speed of the ship
    public Vector2 speed = new Vector2(5, 5);

    private Vector2 movement;

    public Vector2 direction = new Vector2(1, 0);


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Direction
        movement = new Vector2(
             direction.x * speed.x,
             direction.y * speed.y);

        if (GameObject.FindGameObjectWithTag("Enemy") == true)
        {
            Vector2 RandomDirection = new Vector2(Random.Range(1f, -1f), Random.Range(0f, -1f));
            direction = RandomDirection;
            Debug.Log("Enemy Random Direction");
        }

    }

    void FixedUpdate()
    {
        // Object Movement
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
