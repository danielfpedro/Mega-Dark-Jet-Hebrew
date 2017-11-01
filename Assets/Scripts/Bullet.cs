using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float force = 10f;
	public float damage = 40f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		// Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		//rb.AddRelativeForce (transform.parent.transform.forward * force);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.GetComponent<HealthManager> () != null) {
			coll.gameObject.GetComponent<HealthManager> ().Hurt (Mathf.Round(Random.Range(1f, 10f)), coll.contacts);	

			/**GameObject p = coll.collider.gameObject.GetComponent<Enemy> ().p;
			p.transform.position = new Vector3 (p.transform.position.x, p.transform.position.y, coll.transform.position.z + 1f);

			Vector2 hitPoint = coll.contacts[0].point;
			Instantiate(p, new Vector3(hitPoint.x, hitPoint.y, 0), p.transform.rotation);**/
		}	
		if (coll.gameObject.tag == "Enemy") {
			EventManager.TriggerEvent ("enemyHit");
		}

		Destroy (gameObject);	
	}
}
