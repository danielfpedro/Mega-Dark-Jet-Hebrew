using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour {

	private Camera mainCamera;
	private int lastPosition;

    public enum AlignHorizontalOptions : int { None = -1, Left = 0, Right = 1 };
    public enum AlignVerticalOptions : int { None = -1, Bottom = 0, Top = 1 };

    public AlignHorizontalOptions alignHorizontal;
    public AlignVerticalOptions alignVertical;

    // Use this for initialization
    void Start () {
		mainCamera = Camera.main;
		lastPosition = transform.childCount - 1;

        SetBoxColliderOnChildren();
        AlignFirst();
        RepositioningBackground();
	}

    private void AlignFirst()
    {
        if ((int)alignHorizontal >= 0)
        {
            transform.position = new Vector2(ScreenAlignHelper.GetPosition("x", transform.GetChild(0), (int)alignHorizontal), transform.position.y);
        }
        if ((int)alignVertical >= 0)
        {
            transform.position = new Vector2(transform.position.x, ScreenAlignHelper.GetPosition("y", transform.GetChild(0), (int)alignVertical));
        }
    }

    // Update is called once per frame
    void Update () {
		int i = 0;

		foreach (Transform child in transform) {

			BoxCollider2D boxCollider = child.gameObject.GetComponent<BoxCollider2D> ();

			Vector3 size = mainCamera.ScreenToWorldPoint (new Vector3 (0, 0, 5));

			if (child.transform.position.x < (size.x - (boxCollider.size.x / 2f))) {
                child.position = ScreenAlignHelper.PositionObjectSideBySide (transform.GetChild (lastPosition), child);
				lastPosition = i;
			}
			i++;
		}
	}

    private void SetBoxColliderOnChildren() {
        foreach (Transform child in transform) {
            if (child.gameObject.GetComponent<BoxCollider2D>() == null)
            {
                child.gameObject.AddComponent<BoxCollider2D>();
                BoxCollider2D boxCollider = child.GetComponent<BoxCollider2D>();
                boxCollider.isTrigger = true;
            }
        }
    }

    // Ajusta todos de acordo com o primeiro
	private void RepositioningBackground() {
		int i = 0;

        Transform last = null;
		foreach (Transform child in transform) {
            // Checo se o sprite tme colllider se ainda não
            // eu coloco e seto trigger
            // Como eu testo e se nao tem eu colocar obivio ele coloca só uma vez
            if (i > 0) {
                Debug.Log("Poszy " + ScreenAlignHelper.PositionObjectSideBySide(transform.GetChild(i - 1), child));
                child.position = ScreenAlignHelper.PositionObjectSideBySide(last, child);
            }

            last = child;
            i++;

        }
	}
}
