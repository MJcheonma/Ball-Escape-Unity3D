using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float initialRotationSpeed = 20.0f;
    public float rotationSpeedIncrease = 20.0f;
    public float delay = 0.25f;
    
    private float rotationSpeed;
    private float lastspeedDelay;

    void Start()
    {
        rotationSpeed = initialRotationSpeed;
        lastspeedDelay = Time.time;

    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        if (horizontalInput != 0 && Time.time > lastspeedDelay + delay)
        {
            rotationSpeed += rotationSpeedIncrease;
            lastspeedDelay = Time.time;
        }

        else if(horizontalInput == 0)
        {
            rotationSpeed = initialRotationSpeed;
        }
    }


}
