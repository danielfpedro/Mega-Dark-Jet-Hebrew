using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerBoundary
{
	public float xMinOffset, xMaxOffset, yMinOffset, yMaxOffset;
}

public class PlayerController : MonoBehaviour {

	public PlayerBoundary playerBoundary;

	private Rigidbody2D rb;
	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
		rb = GetComponent<Rigidbody2D> ();

		// canMove = true;
		//selectWeapon ();
	}

	void Update() {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 screenWorldPoint = Camera.main.ScreenToWorldPoint(new Vector3(0,0, 0.5f));
		rb.position = new Vector2 (
			Mathf.Clamp(rb.position.x, screenWorldPoint.x + playerBoundary.xMinOffset, Mathf.Abs(screenWorldPoint.x) - playerBoundary.xMaxOffset),
			Mathf.Clamp(rb.position.y, screenWorldPoint.y + playerBoundary.yMinOffset, Mathf.Abs(screenWorldPoint.y) - playerBoundary.yMaxOffset)
		);
	}
}
