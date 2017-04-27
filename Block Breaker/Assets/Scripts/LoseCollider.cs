﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    private LevelManager levelManager; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collider");
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose");

    }
}
