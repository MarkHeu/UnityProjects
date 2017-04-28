﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 paddletoBallVector;
    private Rigidbody2D rb;
    private AudioSource auso; 
    private bool hasStarted = false; 
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddletoBallVector = this.transform.position - paddle.transform.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddletoBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true; 
                rb.velocity = new Vector2(2f, 10f); //Launch the Ball 
            }
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        if (hasStarted)
        {
            auso = GetComponent<AudioSource>();
            auso.Play();
            rb.velocity = rb.velocity + tweak; 
        }
    }
}
