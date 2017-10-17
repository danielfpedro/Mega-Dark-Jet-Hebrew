using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 10f;
	public int damage = 40;

	public float shotSpeed = 100f;
	public float gravityScale= 0f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(speed, 0f);
		rb.gravityScale = gravityScale;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Enemy") {
			collider.gameObject.GetComponent<HealthManager> ().hurt(damage);
			Destroy (gameObject);	
		}
	}
}
