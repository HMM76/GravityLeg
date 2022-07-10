using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    Rigidbody2D rb;
    Collider2D cl;
    public bool isGrounded;
    public bool isCeiled;
    public bool isDead;
    public float speed;
    public int n = 0;
    public MainMenu mm;
    public Points p;
    public PointsLast pl;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<Collider2D>();
        isDead = false;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {

            n++;
            print(n);
            p.Text.text = n.ToString();
        }
       

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            isDead = true;
            mm.Window();
            pl.text.text = n.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grrnd"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("cllng"))
        {
            isCeiled = true;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grrnd"))
        {
            isGrounded = false;
        }

        if (collision.gameObject.CompareTag("cllng"))
        {
            isCeiled = false;
        }
    }
    private void FixedUpdate()
    {
        if(isGrounded == true && Input.GetKey(KeyCode.Space))
        {
            rb.gravityScale = -3;
            print("g");
        }

        if(isCeiled == true && Input.GetKey(KeyCode.Space))
        {
            rb.gravityScale = 3;
            print("c");
        }
    }
}
