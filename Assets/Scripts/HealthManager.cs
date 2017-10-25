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

	public void KillIt() {
		currentHealth = 0;
	}

	public void Hurt(int damage, Vector2 point) {

		Instantiate (pe, point, transform.rotation);

		currentHealth -= damage;
	}
}
