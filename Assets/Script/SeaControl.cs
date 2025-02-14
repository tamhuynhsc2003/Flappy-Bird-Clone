using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaControl : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;
    private float startTime;
    private Vector3 initialPosition;


    void Start()
    {
        startTime = Time.time;
        initialPosition = transform.position;
    }

    void Update()
    {
        float yPos = initialPosition.y + Mathf.Sin((Time.time - startTime) * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

}
