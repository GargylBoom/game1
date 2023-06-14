using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
   

    public float jumpSpeed = 2f;
    public float straifspeed = 2f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        jump();
        right();
        left();

    }
    public void jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            
        }
    }
    public void right()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {

            rb.AddForce(Vector2.right * straifspeed, ForceMode2D.Impulse);

        }
    }
    public void left()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            rb.AddForce(Vector2.left * straifspeed, ForceMode2D.Impulse);

        }
    }
   
}

