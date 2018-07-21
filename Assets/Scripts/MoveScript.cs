using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    // The speed of the ship
    public Vector2 speed = new Vector2 (5, 5);

	private Vector2 movement;

	public Vector2 direction = new Vector2 (1, 0);

	// Update is called once per frame
	void Update () {
	
		// Direction
		movement = new Vector2 (
			 direction.x * speed.x,
			 direction.y * speed.y);
	}

	void FixedUpdate() {
        // Object Movement
        GetComponent<Rigidbody2D>().velocity = movement;
	}
}
