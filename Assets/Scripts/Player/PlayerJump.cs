using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7;

    [SerializeField] private Transform groundPoint;

    [SerializeField] private LayerMask groundLayer;
    private float groundRadius = 0.5f;
    private bool onGround;

    private bool pressingJump;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CheckGround();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressingJump = true;
        }
    }
    private void FixedUpdate()
    {
        if (pressingJump && onGround)
        {
            rb.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
            pressingJump = false;
        }
    }
    private void CheckGround()
    {
        onGround = Physics2D.OverlapCircle(groundPoint.position, groundRadius, groundLayer);
    }
}
