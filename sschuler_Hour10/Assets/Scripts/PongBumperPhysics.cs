using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBumperPhysics : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        rb.velocity = movement * moveSpeed;
    }
}