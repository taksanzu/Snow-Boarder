using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float torqueForce = 3f;
    [SerializeField] float bootsForce = 20f;
    [SerializeField] float baseSpeed = 10f;

    Rigidbody2D playerRigidbody;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        surfaceEffector2D.speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        BoostSpeed();
    }

    private void BoostSpeed()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            surfaceEffector2D.speed = bootsForce;
        }else if(Input.GetKeyUp(KeyCode.Space))
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddTorque(torqueForce);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddTorque(-torqueForce);
        }
    }
}
