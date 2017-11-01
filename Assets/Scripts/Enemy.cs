using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rb;

	public GameObject p;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.DrawRay (new Vector2(transform.position.x, transform.position.y), -Vector2.right * 30f, Color.green);
	}

    void FixedUpdate() {
		

		/**RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, -Vector2.right * 30f);

		BoxCollider2D boxCollider = GetComponent<BoxCollider2D> ();
		Debug.DrawRay (new Vector2(transform.position.x, transform.position.y - (1)), -Vector2.right * 30f, Color.red)

		foreach(RaycastHit2D hit in hits) {
			if (hit.collider != null) {
				Debug.Log ("Hiting: " + hit.collider.tag);
				if (hit.collider.tag == "Hero") {
					
				}
			}	
		}**/
    }
}
