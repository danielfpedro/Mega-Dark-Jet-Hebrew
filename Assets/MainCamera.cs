using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	public GameController gameController;

	private float zPosition = -10f;
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		Transform targetPosition = gameController.Hero.transform;

		// Coloco o Z manualmente par deixar a camera na frente do cenario 
		transform.position = new Vector3 (transform.position.x, targetPosition.position.y, zPosition);
	}

	void Update(){
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		// rb.velocity = Vector2.right * GameController.heroDefaultSpeed;
	}
}
