using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Background {
	public float[] paralaxLayersSpeed;
}

public class GameController : MonoBehaviour {

	public static GameController instance;
	public static float heroDefaultSpeed = 0f;
	public GameObject Hero;
	public Background background;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}

		// background.paralaxLayersSpeed = new float[background.howManyLayers];
		/**for (int i = 0; i < background.howManyLayers; i++) {
			background[i] = 
		}*/

	}

	// Use this for initialization
	void Start () {
		// Instantiate (Hero, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Instantiate (Hero, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
		}
	}
}
