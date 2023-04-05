using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float playerSpeed = 10;
    public float jumpForce = 5;
    public Transform groundCheck;
    public LayerMask groundlayer;
    public Vector2 checkboxsize = new Vector2(0.5f, 0.2f);

    private Rigidbody2D rb;
    private float moveInput;
    private bool isGrounded;
    private bool facingright;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapBox(groundCheck.position, checkboxsize, 0f, groundlayer);

        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }


        if (moveInput > 0 && facingright)
        {
            Flip();
        }

        if (moveInput < 0 && !facingright)
        {
            Flip();
        }



    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * playerSpeed, rb.velocity.y);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingright = !facingright;
    }
}