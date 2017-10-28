using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator animator = GetComponent<Animator> ();
		AnimatorClipInfo clipInfo = animator.GetCurrentAnimatorClipInfo (0)[0];
		Destroy (gameObject, clipInfo.clip.length);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetText(float damage) {
		GetComponent<Text>().text = damage.ToString();
	}
}
