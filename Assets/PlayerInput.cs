using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(JetController))]
public class PlayerInput : MonoBehaviour {

    private JetController jetController;

	// Use this for initialization
	void Start () {
        jetController = GetComponent<JetController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        jetController.move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

}
