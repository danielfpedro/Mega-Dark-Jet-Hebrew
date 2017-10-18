using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeroBoundary
{
	public float xMin, xMax, yMin, yMax;
}

public class HeroController : MonoBehaviour {

	public HeroBoundary heroBoundary;

	public float speed = 10f;
	public int selectedWeapon = 0;

	public bool isPlayer = false;

	public Transform weapons;

	private Rigidbody2D rb;

	public bool canMove;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		canMove = true;

		selectWeapon ();
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Alpha1) && weapons.transform.childCount > 0) {
			selectedWeapon = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && weapons.transform.childCount > 1) {
			selectedWeapon = 1;
		}

		selectWeapon ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		move ();

		rb.position = new Vector2 (
			Mathf.Clamp(rb.position.x, heroBoundary.xMin, heroBoundary.xMax),
			Mathf.Clamp(rb.position.y, heroBoundary.yMin, heroBoundary.yMax)
		);
	}

	float getSpeed(string type) {

		if (type == "horizontal") {
			return (Input.GetAxis("Horizontal") != 0 && canMove && isPlayer) ? Input.GetAxis ("Horizontal") * speed : GameController.heroDefaultSpeed;
		}
		if (type == "vertical") {
			return (canMove && isPlayer) ? Input.GetAxis ("Vertical") * speed : 0f;
		}

		return 0f;
	}

	void move() {
		rb.velocity = new Vector2 (getSpeed("horizontal"), getSpeed("vertical"));
	}

	void selectWeapon() {

		int i = 0;
		foreach (Transform weapon in weapons) {
			bool state = (i == selectedWeapon) ? true : false;
			weapon.gameObject.SetActive (state);
			i++;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("BATEU OS MENONOS");
		if (coll.gameObject.tag == "Enemy") {
			HealthManager hm = GetComponent<HealthManager> ();
			hm.KillIt ();
		}
	}
}
