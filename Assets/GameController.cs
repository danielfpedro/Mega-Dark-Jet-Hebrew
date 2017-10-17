using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


	public static float heroDefaultSpeed = 0f;
	public GameObject Hero;

	// Use this for initialization
	void Start () {
		Instantiate (Hero, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Instantiate (Hero, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
		}
	}
}
