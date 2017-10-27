using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAlign : MonoBehaviour {

	public bool alignLeftBottom = false;

	// Use this for initialization
	void Start () {

		if (alignLeftBottom) {
			Positioning (transform, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PositionObjectSideBySide(Transform object1, Transform object2) {
		Vector3 max= object1.GetComponent<BoxCollider2D> ().bounds.max;
		object2.position = new Vector2(max.x + (object2.GetComponent<BoxCollider2D>().size.x / 2f), object2.position .y);
	}


	public void Positioning(Transform object1, int x, int? y) {
		Vector3 size = Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 5));

		float xPosition = object1.position.x;
		if (x == 0) {
			xPosition = size.x + (object1.gameObject.GetComponent<BoxCollider2D> ().size.x / 2f);	
		} else if (x == 1) {
			xPosition = size.x + (object1.gameObject.GetComponent<BoxCollider2D> ().size.x / 2f);	
		}

		float yPosition = object1.position.y;
		if (y == 0) {
			yPosition = size.y + (object1.gameObject.GetComponent<BoxCollider2D> ().size.y / 2f);	
		} else if (y == 1) {
			yPosition = size.y + (object1.gameObject.GetComponent<BoxCollider2D> ().size.y / 2f);	
		}

		object1.position = new Vector2 (xPosition, yPosition);
	}

}
