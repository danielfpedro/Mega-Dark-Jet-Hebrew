using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboController : MonoBehaviour {

	private int totalHits = 0;
	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		text.text = totalHits.ToString();
	}

	void OnEnable() {
		EventManager.StartListening ("enemyHit", EnemyHitIteration);
	}
	void OnDisable() {
		EventManager.StopListening ("enemyHit", EnemyHitIteration);
	}

	void EnemyHitIteration() {
		totalHits++;
	}
}
