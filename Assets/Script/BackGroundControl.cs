using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundControl : MonoBehaviour
{
    public Vector2 spawnPoint ;
    public float resetPoint ;
    public float speed = 2.0f;

    void Start()
    {
        spawnPoint = new Vector2(4.655f, -4f);
        resetPoint = -4.655f;
    }

    void Update()
    {
        if (this.transform.position.x <= resetPoint)
        {
            this.transform.position = spawnPoint;
        }
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

}