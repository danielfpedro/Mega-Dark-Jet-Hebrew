using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemAutoDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float deathDelay = GetComponent<ParticleSystem>().main.duration;
        Destroy(gameObject, deathDelay);
    }
}
