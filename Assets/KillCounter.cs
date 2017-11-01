using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour {

	private int totalKills = 0;
	public float combobreakDeadline = 4f;
	public float combobreakTimer;
	private Text text;
	public Image bar;

	private float timer;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = totalKills.ToString() + " Combo";

		timer += Time.deltaTime;
		combobreakTimer = timer;

		Debug.Log ("Timer in seconds" + combobreakTimer);
	
		bar.fillAmount = (totalKills < 1) ? 1f : combobreakTimer / combobreakDeadline;

		if (combobreakTimer >= combobreakDeadline) {
			ResetCounter ();
		}



	}

	void OnEnable() {
		EventManager.StartListening ("enemyKilled", EnemyKillIteration);
	}
	void OnDisable() {
		EventManager.StopListening ("enemyKilled", EnemyKillIteration);
	}

	void ResetCounter() {
		timer = 0f;
		totalKills = 0;
	}

	void EnemyKillIteration() {
		timer = 0;
		totalKills++;
		Debug.Log ("Enemy Killed");
	}
}
