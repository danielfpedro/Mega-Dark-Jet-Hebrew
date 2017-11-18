using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaw : MonoBehaviour {

    public Transform target;

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

        HomingMissile shotHoming = shot.GetComponent<HomingMissile>();
        if (shotHoming)
        {
            shotHoming.target = target;
        }

        /**BulletController shotController = shot.GetComponent<BulletController>();
        shotController.damage = damage;
        shotController.force = force;
        shotController.facingRight = facingRight;**/

        /**GameObject shot = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		shot.transform.SetParent (transform);
		shot.layer = 10;

		Rigidbody2D shotRb = shot.GetComponent<Rigidbody2D> ();
		Vector2 direction = (facingRight) ? Vector2.right : Vector2.left;
		shotRb.AddRelativeForce (direction * force);**/
    }
}
