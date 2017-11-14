using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaw : MonoBehaviour {

	public GameObject ammo;
	public float force = 150f;
    public float damage = 5f;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shot() {
        bool facingRight = (transform.root.localScale.x >= 0);
        GameObject shot = Instantiate(ammo, transform.position, transform.rotation) as GameObject;
        if (!facingRight)
        {
            shot.transform.localScale = new Vector2(shot.transform.localScale.x * -1, shot.transform.localScale.y);
        }
        shot.GetComponent<BulletController>().damage = damage;
        Rigidbody2D ammoRb = shot.GetComponent<Rigidbody2D>();
        ammoRb.AddRelativeForce(((facingRight) ? Vector2.right : Vector2.left) * force);

        /**GameObject shot = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		shot.transform.SetParent (transform);
		shot.layer = 10;

		Rigidbody2D shotRb = shot.GetComponent<Rigidbody2D> ();
		Vector2 direction = (facingRight) ? Vector2.right : Vector2.left;
		shotRb.AddRelativeForce (direction * force);**/
    }
}
