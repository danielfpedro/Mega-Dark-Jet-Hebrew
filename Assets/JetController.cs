using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JetEffects
{
	public GameObject piercingHit;
}

[RequireComponent(typeof(HealthManager))]
public class JetController : MonoBehaviour {

    public float speed = 10f;

    private Rigidbody2D rb;
    public JetEffects jetEffects;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void Update () {

    }

    void FixedUpdate() {
    }

    public void move(float x, float y)
    {
        rb.velocity = new Vector2(x * speed, y * speed);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            // Como é 2d e o tiro sempre vem de frente não precisa
            // fazer um loop sobre os contatos.. só pega o primeiro e está ótimo

            Vector2 hitPoint = coll.contacts[0].point;
            Debug.Log("Bullet Type " + coll.gameObject.GetComponent<Bullet>().type);

            if (coll.gameObject.GetComponent<Bullet>().type == 0 && jetEffects.piercingHit)
            {
                Instantiate(jetEffects.piercingHit, new Vector3(hitPoint.x, hitPoint.y, 0), Quaternion.identity);
            }    
        }
    }

}
