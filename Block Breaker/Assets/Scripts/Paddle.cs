using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    private float mousepos;
    public bool autoPlay = false;
    private Ball ball;
    private Vector3 paddlePos; 
    // Use this for initialization
    void Start ()
    {
        ball = GameObject.FindObjectOfType<Ball>(); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay(); 
        }

        
	}
    void MoveWithMouse()
    {
        paddlePos = new Vector3(0.5f, this.transform.position.y, -4f);
        mousepos = (Input.mousePosition.x / Screen.width * 16);
        paddlePos.x = Mathf.Clamp(mousepos, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }
    void AutoPlay()
    {
        paddlePos = new Vector3(0.5f, this.transform.position.y, -4f);
        Vector3 ballPos = ball.transform.position; 
        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }
}
