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

	public Image healthBar;
	public GameObject damageText;

	public float health = 100;
    public HealthEffects effects;

    [HideInInspector]
	public float currentHealth;
    

	// Use this for initialization
	void Start () {
		currentHealth = health;
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
                GameObject explosion = Instantiate(effects.dieByExplosion, new Vector3(transform.position.x, transform.position.y, transform.position.z - 50f), transform.rotation);
                float deathDelay = explosion.GetComponent<ParticleSystem>().main.duration;
                Destroy(explosion, deathDelay);
            }
            EventManager.TriggerEvent("enemyKilled");
        }
        

        Destroy (gameObject);
	}

	public void DoDamage(float damage, ContactPoint2D[] contacts) {
		currentHealth -= damage;
		healthBar.fillAmount = currentHealth / health;

		//GameObject damageTextClone = Instantiate (damageText, transform);
		//damageTextClone.GetComponent<DamageTextController> ().text.SetText (damage);
	}
}
