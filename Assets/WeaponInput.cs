using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Weapon))]
public class WeaponInput : MonoBehaviour {

    private Weapon weapon;

	// Use this for initialization
	void Start () {
        weapon = GetComponent<Weapon>();
	}

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            weapon.Shot();
        }   
    }
}
