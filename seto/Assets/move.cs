﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float dirX,dirY, movespeed;
    private Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        movespeed = 5f;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw ("Horizontal") * movespeed;
        dirY = Input.GetAxisRaw ("Vertical") * movespeed;

    
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX,dirY);
    }
    private void LateUpdate()
    {
        if(rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if(rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-localScale.x, localScale.y , localScale.z);
        }
    }
}