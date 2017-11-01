using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDown : MonoBehaviour {


	Transform weapon;

	// Use this for initialization
	void Start () {
		GetComponent<EnemyMovement> ().move (0, -1f);

		// weapon = transform.Find ("Weapons").GetChild (0);

		// InvokeRepeating ("Shot", Random.Range(1f, 1.5f), Random.Range(1f, 1.5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/**private void Shot() {
		weapon.GetComponent<Weapon>().Shot ();
	}**/
}
