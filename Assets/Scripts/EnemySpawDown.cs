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
		GameObject clone = Instantiate (enemy, transform.position, new Quaternion(transform.rotation.x, 180f, transform.rotation.z, transform.rotation.w));
        clone.AddComponent<AIDown>();
        // clone.AddComponent<EnemyJetAI>();
        // EnemyJetAI eAI = clone.GetComponent<EnemyJetAI>();
    }
}
