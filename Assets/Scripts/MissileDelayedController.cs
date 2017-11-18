using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class MissileDelayedController : MonoBehaviour
{

    // Não mostra no inspector pq o spawner
    // que vai dizer quanto tem de dano pq tem upgrade na arma e tal
    public float damage;
    public float speed;
    public float delay = 2f;

    private float gravityScale = 1f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;

        Invoke("Go", delay);
        
    }

    void Go() {
        rb.AddRelativeForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

    }

}
