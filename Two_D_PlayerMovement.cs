using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_D_PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 8f;//default is 8
    [SerializeField] private float jumpForce = 30f;//default is 30
    [SerializeField] private int maxJumps = 2;//default is 2
    private int jumps = 0;//the amount of jumps player has done
    [SerializeField] private bool isGrounded = true;//Checks if player is touching the ground - default true
    [SerializeField] private bool facingRight = true;//Checks if player is looking right - default true

    SpriteRenderer sr;//the player's sprite renderer
    Rigidbody2D rb;//the player's rigidbody


    // Start is called before the first frame update
    void Start()
    {
        /*Get Components - SpriteRenderer & Rigidbody2D*/
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    
    private void OnCollisionEnter2D(Collision2D col)
    {
        /*When Colliding With The Ground*/
        if (col.gameObject.tag == "ground") {
            isGrounded = true;
            jumps = 0;
        }
    }

    private void Move() {
        /*Jump*/
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumps < maxJumps) {
            isGrounded = false;
            jumps++;
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        /*Moves Left and Right*/
        if (Input.GetKey(KeyCode.RightArrow))//right
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            facingRight = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//left
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            facingRight = false;
        }

        Flip();
    }

    /*Flips Sprites On X-Axis Using SpriteRenderer Component*/
    private void Flip() {
        if (!facingRight)
            sr.flipX = true;
        else
            sr.flipX = false;
    }
}
