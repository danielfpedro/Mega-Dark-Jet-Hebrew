using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	public float speed = 1f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = Vector2.right * -speed;
	}
}
