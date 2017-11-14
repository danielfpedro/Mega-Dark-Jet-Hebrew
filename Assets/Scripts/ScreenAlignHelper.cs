using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAlignHelper {

    public static float GetPosition(string axis, Transform element, int orientation)
    {
        Vector3 size = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        Vector2 colliderSize = element.gameObject.GetComponent<BoxCollider2D>().size;

        size *= (orientation == 0) ? 1 : -1;

        float colliderSizeFloat = (axis == "x") ? colliderSize.x : colliderSize.y;

        if (orientation == 0)
        {
            return (((axis == "x") ? size.x : size.y)) + (colliderSizeFloat / 2f);
        }
        else if (orientation == 1)
        {
            return (((axis == "x") ? size.x : size.y)) - (colliderSizeFloat / 2f);
        }
        else
        {
            return (axis == "x") ? element.position.x : element.position.y;
        }
    }

    public static Vector2 PositionObjectSideBySide(Transform object1, Transform object2)
    {
        Vector3 max = object1.GetComponent<BoxCollider2D>().bounds.max;

        return new Vector2(max.x + (object2.GetComponent<BoxCollider2D>().size.x / 2f), max.y - (object2.GetComponent<BoxCollider2D>().size.y / 2f));
    }

}
