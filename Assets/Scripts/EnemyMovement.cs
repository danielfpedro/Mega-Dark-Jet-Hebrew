using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
	}

	public void move(float x, float y) {
		rb.velocity = new Vector2(x * speed, y * speed);
	}

}
