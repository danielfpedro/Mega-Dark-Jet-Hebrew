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
    public float force;
    public float rotateSpeed = 200f;
    public bool facingRight;

    public Types type;

	private Rigidbody2D rb;

    public Transform target;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        // target = GameObject.FindGameObjectWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();

        Vector2 directionFacing = transform.right;

        float rotateAmount = Vector3.Cross(direction, directionFacing).z;

        rb.angularVelocity = rotateAmount * rotateSpeed;
        rb.velocity = directionFacing * force;
    }

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.GetComponent<HealthManager>() != null && coll.gameObject.tag == "Player" || coll.gameObject.tag == "Enemy") {
			coll.gameObject.GetComponent<HealthManager> ().DoDamage (Mathf.Round(Random.Range(damage, damage)), coll.contacts);	
		}
		if (coll.gameObject.tag == "Enemy") {
			EventManager.TriggerEvent ("enemyHit");
		}

		Destroy (gameObject);
	}
}
