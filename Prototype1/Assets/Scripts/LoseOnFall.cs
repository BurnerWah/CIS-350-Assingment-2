/*
 * Jaden Pleasants
 * Assignment 2
 * This code makes it that when the player falls off the road, they lose.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach this to player
public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
