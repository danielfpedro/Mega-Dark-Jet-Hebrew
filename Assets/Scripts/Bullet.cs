using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float force = 10f;
	public float damage = 40f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddRelativeForce (Vector2.right * force);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			coll.gameObject.GetComponent<HealthManager> ().Hurt (Mathf.Round(Random.Range(1f, 10f)), coll.contacts);
			Destroy (gameObject);	
		}
	}
}
