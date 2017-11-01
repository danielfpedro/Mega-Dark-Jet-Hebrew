using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawDown : MonoBehaviour {

	public float spawRate = 1f;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawEnemy", 0.1f, spawRate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawEnemy() {
		Instantiate (enemy, transform.position, transform.rotation);
	}
}
