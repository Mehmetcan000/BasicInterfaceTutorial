using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObjectManager : MonoBehaviour
{




    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
    }
    

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(mousePosition, Vector2.zero);

            IClickable clickable = hit2D.collider.GetComponent<IClickable>();

            if (clickable !=null)
            {
                clickable.Click();
            }
        }
    }
}
