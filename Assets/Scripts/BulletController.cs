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
    public float speed;

    public Types type;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.velocity = transform.right * speed;

    }

}
