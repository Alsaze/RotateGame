using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintRotation : MonoBehaviour
{
    private float _rotationSpeed = 50;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RightRotate();   
        }

        if (Input.GetKey(KeyCode.A))
        {
            LeftRotate();
        }
    }

    public void RightRotate()
    {
        Debug.Log("RightButton");
        transform.Rotate(Vector3.forward  * _rotationSpeed * Time.fixedDeltaTime);
    }

    public void LeftRotate()
    {
        Debug.Log("LeftButton");
        transform.Rotate(-Vector3.forward  * _rotationSpeed * Time.fixedDeltaTime);
    }
}