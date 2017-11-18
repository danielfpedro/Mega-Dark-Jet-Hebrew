using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour {

    public Transform target;
    public float speed = 5f;
    public float rotateSpeed = 200f;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 directionFacing = transform.right;

        if (!target)
        {
            // target = GameController.instance.player.transform;
            Debug.Log("Não tenho target");
        }
        else
        {
            Debug.Log("Tenho target");
            Vector2 direction = (Vector2)target.position - rb.position;
            direction.Normalize();

            float rotateAmount = Vector3.Cross(direction, directionFacing).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;
        }
    }
}
