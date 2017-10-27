using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaw : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void shot() {
		GameObject shot = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		shot.layer = 10;
	}
}
