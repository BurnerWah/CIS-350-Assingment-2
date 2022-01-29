﻿/*
 * Jaden Pleasants
 * Assignment 2
 * Makes the player lose when they're out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsOOB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 80 || transform.position.y <= -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
