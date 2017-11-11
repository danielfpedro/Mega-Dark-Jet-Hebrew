using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(JetController))]
public class AIDown : MonoBehaviour {

    private JetController jetController;

    Transform weapon;

	// Use this for initialization
	void Start () {
        jetController = GetComponent<JetController>();
		// weapon = transform.Find ("Weapons").GetChild (0);

		// InvokeRepeating ("Shot", Random.Range(1f, 1.5f), Random.Range(1f, 1.5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        jetController.move(0f, -1f);
    }

    /**private void Shot() {
		weapon.GetComponent<Weapon>().Shot ();
	}**/
}
