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

		float xMove = (followHorizontal) ? Mathf.Lerp (transform.position.x, target.position.x, horizontallFollowSpeed) : transform.position.x;
		float yMove = (followVertical) ? Mathf.Lerp (transform.position.y, target.position.y, verticalFollowSpeed) : transform.position.y;
		transform.position = new Vector2(xMove, yMove);

		/**float range = 1f;
		float rangeCenter = 0.1f;
		float lockSpeed = 1f;
		if (transform.position.y > target.position.y - range && transform.position.y < target.position.y + range) {
			if (transform.position.y > target.position.y - rangeCenter && transform.position.y < target.position.y + rangeCenter) {
				movement.move (0, 0);
			} else if (transform.position.y > target.position.y) {
				movement.move (0, -lockSpeed);
			} else if (transform.position.y < target.position.y) {
				movement.move (0, lockSpeed);
			}

		} else if (target.position.y > transform.position.y) {
			movement.move (0, 1f);
		} else if (target.position.y < transform.position.y) {
			movement.move (0, -1f);
		}**/

	}
}
