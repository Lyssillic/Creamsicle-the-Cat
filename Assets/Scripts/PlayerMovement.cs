using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float turnSpeed = 200.0f;
    private float speed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Moves the cat forward based on vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the cat based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

        // Animates the cat walking
        bool isWalking = !Mathf.Approximately(forwardInput, 0f);
        m_Animator.SetBool("IsWalking", isWalking);

        // Increases the cat's speed when left control is pressed
        bool isRunning = Input.GetKey(KeyCode.LeftControl) ? true : false;
        speed = isRunning ? 10.0f : 5.0f;

        // Animates the cat running
        m_Animator.SetBool("IsRunning", isRunning);

        // TODO: Figure out jump mechanic
        //var jump = Input.GetKey(KeyCode.Space) ? true : false;
        //m_Animator.SetBool("IsJumping", jump);
    }
}
