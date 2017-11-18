using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

	private BoxCollider2D boxCollider;

	// Use this for initialization
	void Start () {

		boxCollider = GetComponent<BoxCollider2D> ();

		float height = 2f * Camera.main.orthographicSize;
		float width = height * Camera.main.aspect;
		boxCollider.size = new Vector2(width, height);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.tag == "Enemy" || collider.tag == "Bulet") {
			Destroy (collider.gameObject);	
		}

	}
}
