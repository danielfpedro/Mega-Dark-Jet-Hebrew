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
		rb.velocity = Vector2.left * speed;
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Hero") {
			collider.gameObject.GetComponent<HealthManager> ().killIt();
		}
	}
}
