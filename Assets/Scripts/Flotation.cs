using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotation : MonoBehaviour
{
    private float amplitude = 0.2f;
    private float frequency = 0.7f;
    public float delay = 0.0f;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        posOffset = transform.position;
    }

    void Update()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency * delay) * amplitude;
        transform.position = tempPos;
    }
}
