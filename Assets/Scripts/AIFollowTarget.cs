using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollowTarget : MonoBehaviour {

	public Transform target;

	public float horizontallFollowSpeed = 0.1f;
	public float verticalFollowSpeed = 0.1f;

	public bool followHorizontal = false;
	public bool followVertical = true;

	private EnemyMovement movement;

	// Use this for initialization
	void Start () {
		movement = GetComponent<EnemyMovement> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {

		float range = 1f;

		if (transform.position.y > target.position.y - range && transform.position.y < target.position.y + range) {
			
			float xMove = (followHorizontal) ? Mathf.Lerp (transform.position.x, target.position.x, 0.3f) : transform.position.x;
			float yMove = (followVertical) ? Mathf.Lerp (transform.position.y, target.position.y, 0.3f) : transform.position.y;
			transform.position = new Vector2(xMove, yMove);

		} else if (target.position.y > transform.position.y) {
			movement.move (0, 1f);
		} else if (target.position.y < transform.position.y) {
			movement.move (0, -1f);
		}

	}
}
