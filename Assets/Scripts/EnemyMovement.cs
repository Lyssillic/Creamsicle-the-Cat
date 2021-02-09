using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float turnSpeed = 200.0f;
    public float speed = 2.0f;
    public float horizontalInput = 1.0f;
    public float forwardInput = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
