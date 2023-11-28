using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    float startPosX;
    float startPosY;
    bool isBeingHeld;
    // Start is called before the first frame update
    void Update()
    {
        if (isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
        }

    }

    void OnMouseUp()
    {
        isBeingHeld = false;
    }
}