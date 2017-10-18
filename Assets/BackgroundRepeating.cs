using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour {

	private BoxCollider2D boxCollider;
	private float xSize;

	// Use this for initialization
	void Start () {
		boxCollider = GetComponent<BoxCollider2D> ();
		xSize = boxCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < (-xSize * 2f)) {
			RepositionBackground ();
		}
	}

	private void RepositionBackground() {
		Vector2 offset = new Vector2 (xSize * 4f, 0);
		transform.position = (Vector2) transform.position + offset;
	}
}
