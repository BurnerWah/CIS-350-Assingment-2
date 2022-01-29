/*
 * Jaden Pleasants
 * Assignment 2
 * This code allows the player to control their vehicle.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        // Get input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // Move player w/ forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate player w/ horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
