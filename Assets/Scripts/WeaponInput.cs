using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WeaponController))]
public class WeaponInput : MonoBehaviour {

    private WeaponController weapon;

	// Use this for initialization
	void Start () {
        weapon = GetComponent<WeaponController>();
	}

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            weapon.Shot();
        }   
    }
}
