using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Cursor : MonoBehaviour
{
    void Update()
    {
        HandleAiming();
        HandleShooting();
    }


    private void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }

     private void HandleAiming()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }
}
