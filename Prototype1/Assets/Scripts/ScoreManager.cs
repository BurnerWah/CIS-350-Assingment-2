/*
 * Jaden Pleasants
 * Assignment 2
 * This code handles all score-related functions, and some parts of the game state.
 * It processes the win condition, updates the score box, and allows the game to be restarted when it ends.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // display score if game isn't over yet
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        // Win condition: 3 or more points
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\nPress R to try again";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to try again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
