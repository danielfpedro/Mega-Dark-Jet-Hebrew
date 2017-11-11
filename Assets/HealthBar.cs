using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image healthbar;
    public float delayToHide = 0.1f;

    private float timer;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void HideHealthBar()
    {
        gameObject.SetActive(false);
    }

    public void ShowHeatlhBar()
    {
        gameObject.SetActive(true);
        timer = 0;

        Invoke("HideHealthBar", delayToHide);
    }
}
