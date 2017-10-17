﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject bullet;
	public Transform shotSpaw;
	public float fireRate = 0.1f;

	private float nextFire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject shot = Instantiate (bullet, shotSpaw.position, shotSpaw.rotation) as GameObject;
		}
	}
}