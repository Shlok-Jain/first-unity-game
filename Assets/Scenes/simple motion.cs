using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemotion : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0;
        if(Input.GetKey("left")){
            // rb.velocity = new Vector2(-5,0);
            horizontalInput = -1;
        }
        if(Input.GetKey("right")){
            // rb.velocity = new Vector2(5,0);
            horizontalInput = 1;
        }
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
    }
}
