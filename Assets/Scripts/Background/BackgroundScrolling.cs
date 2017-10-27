using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed = 1f;

	private float heroSpeed;

	private GameController gameController;

	// Use this for initialization
	void Start () {
		rb = transform.GetComponent<Rigidbody2D> ();	

		if (rb == null) {
			rb = gameObject.AddComponent (typeof(Rigidbody2D)) as Rigidbody2D;
			rb.bodyType = RigidbodyType2D.Kinematic;
		}
		gameController = GameController.instance;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float multiplier = gameController.heroSpeed * speed;
		rb.velocity = Vector2.right * -multiplier;

		/**for (int i = 0; i < transform.childCount; i++) {
			Rigidbody2D rb = transform.GetChild(i).GetComponent<Rigidbody2D> ();	
			rb.velocity = Vector2.right * -(GameController.instance.background.paralaxLayersSpeed[i]);		
		}**/

	}
}
