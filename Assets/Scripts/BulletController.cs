using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class BulletController : MonoBehaviour {

    public enum Types
    {
        piercing,
        explosive
    }

    // Não mostra no inspector pq o spawner
    // que vai dizer quanto tem de dano pq tem upgrade na arma e tal
	public float damage;
    public Types type;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Enemy") {
			coll.gameObject.GetComponent<HealthManager> ().DoDamage (Mathf.Round(Random.Range(damage, damage)), coll.contacts);	
		}
		if (coll.gameObject.tag == "Enemy") {
			EventManager.TriggerEvent ("enemyHit");
		}

		Destroy (gameObject);
	}
}
