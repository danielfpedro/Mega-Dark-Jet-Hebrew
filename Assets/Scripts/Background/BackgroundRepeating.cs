using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour {

	private Camera mainCamera;
	private int lastPosition;

	private ScreenAlign screenAlign;

	// Use this for initialization
	void Start () {
		// rb = GetComponent<Rigidbody2D> ();
		// gameController = GameController.instance;

		mainCamera = Camera.main;
		lastPosition = transform.childCount - 1;

		screenAlign = GetComponent<ScreenAlign> ();

		RepositionBackground ();
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;

		foreach (Transform child in transform) {

			BoxCollider2D boxCollider = child.gameObject.GetComponent<BoxCollider2D> ();

			Vector3 size = mainCamera.ScreenToWorldPoint (new Vector3 (0, 0, 5));

			if (child.transform.position.x < (size.x - (boxCollider.size.x/2f))) {
				screenAlign.PositionObjectSideBySide (transform.GetChild (lastPosition), child);
				lastPosition = i;
			}
			i++;
		}
	}

	private void RepositionBackground() {
		int i = 0;

		foreach (Transform child in transform) {
			if (child.gameObject.GetComponent<BoxCollider2D> () == null) {
				child.gameObject.AddComponent<BoxCollider2D>();
			}
		}

		foreach (Transform child in transform) {
			BoxCollider2D boxCollider = child.gameObject.GetComponent<BoxCollider2D> ();

			if (i == 0) {
				screenAlign.Positioning(child, 0, null);
			} else {
				screenAlign.PositionObjectSideBySide (transform.GetChild (i - 1), child);
			}
			i++;
		}
	}
}
