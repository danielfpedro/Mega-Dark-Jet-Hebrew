using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public Image healthBar;
	public GameObject damageText;

	public float health = 100;
	[HideInInspector]
	public float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth < 1) {
			KillIt ();
		}
	}

	public void KillIt() {
		if (gameObject.tag == "Enemy") {
			EventManager.TriggerEvent ("enemyKilled");
			Debug.Log ("Inimigo Morreu!");
		}
		Destroy (gameObject);
	}

	public void Hurt(float damage, ContactPoint2D[] contacts) {
		Debug.Log ("You Hurted me");
		currentHealth -= damage;
		healthBar.fillAmount = currentHealth / health;

		//GameObject damageTextClone = Instantiate (damageText, transform);
		//damageTextClone.GetComponent<DamageTextController> ().text.SetText (damage);
	}
}
