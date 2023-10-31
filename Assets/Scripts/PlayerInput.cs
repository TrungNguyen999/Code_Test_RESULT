using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script responsibles for player input handling (touch, drag, click)

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    void Start()
    {
       
    }

    //private void OnMouseDown()
    //{
    //    offset = transform.position - MouseWorldPosition();
    //}

    //Vector3 MouseWorldPosition()
    //{
    //    var mouseScreenPos = Input.mousePosition;
    //    mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
    //    return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    //}

    //private void OnMouseDrag()
    //{
    //    transform.position = MouseWorldPosition() + offset;
    //}

    // Update is called once per frame
    void Update()
    {
       
    }
}
