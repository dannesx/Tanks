﻿using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        Move();
    }

    void Move(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        float rotation = horizontal * rotationSpeed * Time.deltaTime;
        Quaternion turn = Quaternion.Euler(0f, rotation, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }
}