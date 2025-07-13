using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float direction;
    private bool isFacingRight;


    private Rigidbody2D rb;
    private Animator animator;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        direction = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(direction));
        Rotation();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
    }
    private void Rotation()
    {
        if (direction < 0 && isFacingRight)
        {
            Turn();
        }
        else if (direction > 0 && !isFacingRight)
        {
            Turn();
        }
    }
    private void Turn()
    {
        isFacingRight = !isFacingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
