using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerController : MonoBehaviour {

    private ParticleSystem ps;

	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            ps.Play();
        } else
        {
            ps.Stop();
        }
	}
}
