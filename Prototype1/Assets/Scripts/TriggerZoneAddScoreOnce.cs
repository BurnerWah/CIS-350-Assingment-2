/*
 * Jaden Pleasants
 * Assignment 2
 * This code checks if the player has entered a trigger, and if so, updates the score.
 * It then prevents itself from triggering a second time.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
