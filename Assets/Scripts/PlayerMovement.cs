using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] private float speed;
    private float horizontalDirection;
    private float verticalDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalDirection = Input.GetAxisRaw("Horizontal");
        verticalDirection = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 movementVec = new Vector2(horizontalDirection, verticalDirection);
        rb.velocity = movementVec.normalized * speed;
    }
}
