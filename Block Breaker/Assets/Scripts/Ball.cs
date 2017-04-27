using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private Vector3 paddletoBallVector;
    private Rigidbody2D rb;
    private bool hasStarted = false; 
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
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
}
