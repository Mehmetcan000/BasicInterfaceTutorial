using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CircleController : MonoBehaviour ,IClickable
{


    public void Scale()
    {
        transform.DOScale(2f, 1f);
    }

    public void Click()
    {
        Scale();
    }
    
    
    
}
