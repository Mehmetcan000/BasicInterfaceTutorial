using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriangleController : MonoBehaviour , IClickable
{

    public void Rotate()
    {
        transform.DORotate(new Vector3(0, 0, 360f), 1f, RotateMode.FastBeyond360);
    }


    public void Click()
    {
       Rotate();
    }
}
