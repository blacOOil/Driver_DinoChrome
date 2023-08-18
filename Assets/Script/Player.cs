using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public float jumpForce = 500f;
    bool jump = false;
    bool gamestarted = false;
    bool grounded = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //When Try Jump
        if (Input.GetKeyDown("space")) 
        {
            if ((grounded == true) && (gamestarted == true))
            {
                Jump();
                jump = true;
                grounded = false;
            }
            else
            {
                gamestarted = true;
                
            }

            if ((grounded == false) && (Input.GetKeyDown("space")))
            {
                Debug.Log("cant double jump");
            }
        }

        //When Try Stoop
        if (Input.GetKeyDown("s")) 
        {
            if ((grounded == true) && (gamestarted == true))
            {
                jump = false;
                grounded = true;
                Stoop();
            }
            else
            {
                gamestarted = true;
                
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
    
    void Jump() 
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space-key was down.");
        }
        // if (Input.GetKeyUp("space"))
        // {
        //     Debug.Log("Space-key was up.");
        // }
    }

    void Stoop() 
    {
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("S-key was down. Your Stoop.");
        }
        // if (Input.GetKeyUp("s"))
        // {
        //     Debug.Log("S-key was up.");
        // }
    }

    private void FixedUpdate()
    {
        if (gamestarted == true)
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        if (jump == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }
}
