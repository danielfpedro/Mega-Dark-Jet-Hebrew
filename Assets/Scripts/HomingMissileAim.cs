using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissileAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        float distance = 20f;

        Vector3 forward = transform.TransformDirection(Vector3.right);

        Debug.DrawRay(transform.position * distance, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, distance)) {

        }
    }
}
