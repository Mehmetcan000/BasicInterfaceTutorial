using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SquareController : MonoBehaviour , IClickable
{

    public void Move()
    {
        transform.DOMoveY(-3f, 1f);
    }

    public void Click()
    {
          Move();
    }
}
