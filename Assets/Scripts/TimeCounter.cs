using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

	private float hour;
	private float min;
	private float sec;
	private float ms;
	private float timer;

	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		min = Mathf.Floor (timer / 60);
		sec = Mathf.Floor(timer % 60);

		text.text = "00:" + sec.ToString ("00") + ":" + timer.ToString("00");

	}
}
