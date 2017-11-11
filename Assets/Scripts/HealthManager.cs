using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthEffects
{
    public GameObject dieByExplosion;
}

public class HealthManager : MonoBehaviour {

    [HeaderAttribute("Health Bar")]
    public GameObject healthBar;
    public Transform healthBarPosition;

	public float health = 100;
    public HealthEffects effects;

    [HideInInspector]
	public float currentHealth;

    private float timer;
    

	// Use this for initialization
	void Start () {
		currentHealth = health;

        if (healthBar)
        {
            healthBar = Instantiate(healthBar, healthBarPosition.position, healthBarPosition.rotation);
            healthBar.transform.SetParent(transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth < 0.1f) {
			KillIt ();
		}
    }

    public void KillIt() {
		if (gameObject.tag == "Enemy") {
            if (effects.dieByExplosion)
            {
                Instantiate(effects.dieByExplosion, new Vector3(transform.position.x, transform.position.y, transform.position.z - 50f), transform.rotation);
            }
            EventManager.TriggerEvent("enemyKilled");
        }
        

        Destroy (gameObject);
	}

	public void DoDamage(float damage, ContactPoint2D[] contacts) {
		currentHealth -= damage;
		healthBar.GetComponent<HealthBar>().healthbar.fillAmount = currentHealth / health;

        if (healthBar)
        {
            healthBar.GetComponent<HealthBar>().ShowHeatlhBar();
        }
        
    }
}
