using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ScreenAlign : MonoBehaviour {

    public enum AlignHorizontalOptions : int {None = -1, Left = 0, Right = 1};
    public enum AlignVerticalOptions : int { None = -1, Bottom = 0, Top = 1 };

    public AlignHorizontalOptions alignHorizontal;
    public AlignVerticalOptions alignVertical;

    // Use this for initialization
    void Start () {
        if ((int)alignHorizontal >= 0)
        {
            transform.position = new Vector2(ScreenAlignHelper.GetPosition("x", transform, (int)alignHorizontal), transform.position.y);
        }
        if ((int)alignVertical >= 0)
        {
            transform.position = new Vector2(transform.position.x, ScreenAlignHelper.GetPosition("y", transform, (int)alignVertical));
        }
    }

}
