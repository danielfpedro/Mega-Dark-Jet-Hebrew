using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 10f;
	public int damage = 40;

	public float shotSpeed = 100f;
	public float gravityScale = 0f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Debug.Log ("Biriba!");
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(speed, 0f);
		rb.gravityScale = gravityScale;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("BATEU!");
		if (coll.gameObject.tag == "Enemy") {
			foreach(ContactPoint2D contact in coll.contacts) {
				Debug.Log("CONTTO" + contact.point);
				
				object[] parameters = new object[2];

				contact.collider.gameObject.GetComponent<HealthManager> ().Hurt (damage, contact.point);
				Destroy (gameObject);	
			}
		}
	}
}
