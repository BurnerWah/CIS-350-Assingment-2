/*
 * Jaden Pleasants
 * Assignment 2
 * Manages score and game state.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    public static bool gameOver;
    public static bool won;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            if (score >= 5)
            {
                won = true;
                gameOver = true;
            }
            else
            {
                scoreText.text = $"Score: {score}";
                return;
            }
        }
        // gameOver should always be true at this point, so no checks neccesary
        scoreText.text = $"You {(won ? "Won" : "Lose")}!\nPress R to try again";
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
