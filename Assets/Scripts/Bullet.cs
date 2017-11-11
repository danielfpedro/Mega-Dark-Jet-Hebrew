using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public enum Types
    {
        piercing,
        explosive
    }

    public float force = 10f;

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
		if (coll.gameObject.GetComponent<HealthManager> () != null) {
			coll.gameObject.GetComponent<HealthManager> ().DoDamage (Mathf.Round(Random.Range(damage, damage)), coll.contacts);	

			// GameObject p = coll.collider.gameObject.GetComponent<Enemy> ().p;
			//p.transform.position = new Vector3 (p.transform.position.x, p.transform.position.y, coll.transform.position.z + 1f);
            /**
			Vector2 hitPoint = coll.contacts[0].point;
			GameObject pClone = Instantiate(p, new Vector3(hitPoint.x, hitPoint.y, 0), p.transform.rotation);
            Destroy(pClone, pClone.GetComponent<ParticleSystem>().main.duration);**/
		}
		if (coll.gameObject.tag == "Enemy") {
			EventManager.TriggerEvent ("enemyHit");
		}

		Destroy (gameObject);
	}
}
