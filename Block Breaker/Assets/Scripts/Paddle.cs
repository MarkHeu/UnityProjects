using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    private float mousepos;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); 

        mousepos = (Input.mousePosition.x /Screen.width * 16);
        paddlePos.x = Mathf.Clamp(mousepos, 0.5f, 15.5f); 
        this.transform.position = paddlePos; 
        
	}
}
