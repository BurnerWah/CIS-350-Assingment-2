/*
 * Jaden Pleasants
 * Assignment 2
 * This code updates the score when the player enters a trigger zone.
 * It is obseleteted by TriggerZoneAddScoreOnce.cs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
