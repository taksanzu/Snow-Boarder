using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    [SerializeField] private float torqueForce = 3f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            playerRigidbody.AddTorque(torqueForce);  
        } else if (Input.GetKey(KeyCode.RightArrow)){
            playerRigidbody.AddTorque(-torqueForce);
        }
    }
}
