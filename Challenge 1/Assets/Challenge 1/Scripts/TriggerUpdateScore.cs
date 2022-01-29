/*
 * Jaden Pleasants
 * Assignment 2
 * Updates the score the first time the player enters a trigger.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUpdateScore : MonoBehaviour
{
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
