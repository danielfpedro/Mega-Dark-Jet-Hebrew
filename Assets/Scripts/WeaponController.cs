using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

	public float fireRate = 0.1f;
    public bool facingRight = true;

	private float nextFire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Shot() {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			foreach(Transform spaw in transform) {
                spaw.SendMessage("Shot");
			}
		}
	}
}
