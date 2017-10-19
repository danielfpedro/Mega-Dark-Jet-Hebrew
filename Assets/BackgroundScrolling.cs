using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	// private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < transform.childCount; i++) {
			Rigidbody2D rb = transform.GetChild(i).GetComponent<Rigidbody2D> ();	
			rb.velocity = Vector2.right * -(GameController.instance.background.paralaxLayersSpeed[i]);		
		}

	}
}
