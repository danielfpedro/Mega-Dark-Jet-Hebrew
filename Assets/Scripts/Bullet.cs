using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 10f;
	public float gravityScale = 0f;
	public int damage = 40;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		// rb.velocity = new Vector2(speed, 0f);
		rb.gravityScale = gravityScale;
		rb.AddRelativeForce (Vector2.right * speed);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			foreach(ContactPoint2D contact in coll.contacts) {

				contact.collider.gameObject.GetComponent<HealthManager> ().Hurt (damage, contact.point);
				Destroy (gameObject);	
			}
		}
	}
}
