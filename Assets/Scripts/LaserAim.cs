using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserAim : BulletSpaw {

    public LayerMask layerMask;
    private Text aimtext;

	// Use this for initialization
	void Start () {
        aimtext = GameObject.Find("MainCanvas/AimText").GetComponent<Text>();
        aimtext.text = "-";
	}
	
	// Update is called once per frame
	void Update () {
        int rayMaxDistance = 100;
        Ray2D ray = new Ray2D(transform.position, Vector2.right);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, rayMaxDistance, layerMask);

        Debug.DrawLine(transform.position, transform.position + Vector3.right * rayMaxDistance);

        if (hit)
        {
            target = hit.transform;

            ObjectProfile targetProfile = hit.transform.gameObject.GetComponent<ObjectProfile>();
            if (targetProfile)
            {
                aimtext.text = targetProfile.name;
            }
            else {
                aimtext.text = "Inimigo Desconhecido";
            }
            
            // Debug.Log("You hit array" + transform.gameObject);
        }
        else {
            aimtext.text = "-";
            target = null;
        }
    }
}
