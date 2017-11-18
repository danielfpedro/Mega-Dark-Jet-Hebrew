using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController instance;
	public GameObject player;
    public Transform playerSpaw;

	public float heroSpeed = 10f;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}

	}

	// Use this for initialization
	void Start () {
		Instantiate (player, playerSpaw.position, playerSpaw.rotation);

	}
	
	// Update is called once per frame
	void Update () {
	}

	void HeroRespaw() {
		Instantiate (player, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
	}

}
