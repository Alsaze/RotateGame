using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintRotation : MonoBehaviour
{
    private float _rotationSpeed=50;

    private void FixedUpdate() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.forward * horizontalInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}
