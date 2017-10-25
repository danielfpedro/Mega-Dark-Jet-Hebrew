using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour {

	public GameObject[] Enemies;
	public Transform enemySpaw;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawEnemy", 0f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawEnemy() {
		Instantiate (Enemies [0], new Vector3(enemySpaw.position.x, enemySpaw.position.y, 0f), enemySpaw.rotation);
	}
}
