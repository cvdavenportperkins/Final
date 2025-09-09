 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    //variable
    public float speed;
    public float move;
    public float jump;
    public Rigidbody2D rb;

    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;                                                       //set vaiable for move force
        jump = 400f;                                                       //set variable for jump force
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");                                  //set input for movement
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)                      //set imput for jump function
        {
            Debug.Log("space");
            rb.AddForce(new Vector2(rb.velocity.x, jump));                  //declare jump function
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)                       //declare collision function for "Ground"
    {
        if (other.gameObject.CompareTag("Ground"))                           //declare conditition Ground collision
        {
            isJumping = false;
        }
    }
}