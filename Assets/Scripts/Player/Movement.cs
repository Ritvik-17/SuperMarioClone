using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D MarioRigidbody2D;
    public GroundChecker groundCheck;
    public GameObject FollowObject;

    public float Lives = 0;
    private float jumpTimeCounter;
    public float maxJumpTime = 0.35f;
    public float holdJumpForce = 8f;
    private bool isJumping = false;
    public float AddVelocity = 5f;

    void Start()
    {
        MarioRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        MoveXAxis();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform") )
        {          
            jumpTimeCounter = 0f;
        }
    }

    void MoveXAxis(){
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput > 0.01f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            MarioRigidbody2D.velocity = new Vector2(moveInput * AddVelocity, MarioRigidbody2D.velocity.y);
        }
        else if(moveInput < -0.01f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*-1, transform.localScale.y, transform.localScale.z);
            MarioRigidbody2D.velocity = new Vector2(moveInput * AddVelocity, MarioRigidbody2D.velocity.y);
        }
        else
        {
            MarioRigidbody2D.velocity = new Vector2(0, MarioRigidbody2D.velocity.y);
        }
    }

    void Jump(){
        if(Input.GetButtonDown("Jump") && groundCheck.isGrounded)
        {
            MarioRigidbody2D.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetButton("Jump") && isJumping)
        {
            if (jumpTimeCounter < maxJumpTime)
            {
                MarioRigidbody2D.velocity = new Vector2(MarioRigidbody2D.velocity.x, holdJumpForce);
                jumpTimeCounter += Time.deltaTime;
            }
        }
        if(Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Easter")
        {
            FollowObject.GetComponent<FollowMarioInXAxis>().EasterEggEnabled = true;
        }
    }

}
