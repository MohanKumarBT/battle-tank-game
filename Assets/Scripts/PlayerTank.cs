using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : GenericSingleton<PlayerTank>
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        Vector3 move = transform.forward * joystick.Vertical * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }
    private void Rotate()
    {
        float rotate = joystick.Horizontal * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, rotate, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
