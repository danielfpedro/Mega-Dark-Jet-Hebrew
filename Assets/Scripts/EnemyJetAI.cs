using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJetAI : MonoBehaviour {

    public GameObject weapon;
    public float shotRate = 1.5f;

	// Use this for initialization
	void Start () {
        weapon = transform.Find("Weapons/Pinch").gameObject;

        InvokeRepeating("Shot", 0f, shotRate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Shot() {
        weapon.SendMessage("Shot");
    }

}
