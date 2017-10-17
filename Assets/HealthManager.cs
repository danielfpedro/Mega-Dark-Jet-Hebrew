using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

	public int health = 100;
	public int currentHealth;

	public GameObject pe;

	// Use this for initialization
	void Start () {
		currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth < 1) {
			Destroy (gameObject);
		}
	}

	public void killIt() {
		currentHealth = 0;
	}

	public void hurt(int damage) {

		Instantiate (pe, transform.position, transform.rotation);

		currentHealth -= damage;
	}
}
