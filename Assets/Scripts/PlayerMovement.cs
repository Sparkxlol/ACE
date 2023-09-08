using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rb;
    private Animator anim;

    [Header("Movement")]
    [SerializeField] private float speed;
    private float horizontalDirection;
    private float verticalDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontalDirection = Input.GetAxisRaw("Horizontal");
        verticalDirection = Input.GetAxisRaw("Vertical");

        if (horizontalDirection != 0 || verticalDirection != 0)
        {
            anim.SetFloat("Horizontal", horizontalDirection);
            anim.SetFloat("Vertical", verticalDirection);
        }
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
