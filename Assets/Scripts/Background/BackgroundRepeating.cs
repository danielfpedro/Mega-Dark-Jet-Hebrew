using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour {

	private BoxCollider2D boxCollider;
	private float xSize;
	private Rigidbody2D rb;
	private GameController gameController;

	// public GameObject secondBackground;

	// Use this for initialization
	void Start () {
		/**boxCollider = GetComponent<BoxCollider2D> ();
		xSize = boxCollider.size.x;**/

		rb = GetComponent<Rigidbody2D> ();
		gameController = GameController.instance;

		RepositionBackground ();
	}
	
	// Update is called once per frame
	void Update () {

		// rb.velocity = Vector2.right * -30f;

		int i = 0;
		int totalChilds = transform.childCount;
		Debug.Log ("Total Childs: " + totalChilds);
		foreach (Transform child in transform) {
			BoxCollider2D boxCollider = child.gameObject.GetComponent<BoxCollider2D> ();

			if (child.transform.position.x < (-boxCollider.size.x * 2f)) {
				float extra = totalChilds * 2f;
				Debug.Log ("Aplicando offset " + extra + " para child " + i);
				Vector2 offset = new Vector2 (boxCollider.size.x * extra, 0);
				child.position = (Vector2) child.transform.position + offset;
			}
			i++;
		}
		/**if (transform.position.x < (-xSize * 2f)) {
			RepositionBackground ();
		}**/
	}

	private void RepositionBackground() {
		int i = 0;
		int totalChilds = transform.childCount;
		foreach (Transform child in transform) {
			BoxCollider2D boxCollider = child.gameObject.GetComponent<BoxCollider2D> ();
			float xPosition = (i == 0) ? 0 : boxCollider.size.x * i * 2f;
			child.position = new Vector2(xPosition, child.position.y);
			i++;
		}
	}
}
