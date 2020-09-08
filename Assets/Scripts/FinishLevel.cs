using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This class represents all behaviours when a level is completed.
 */
public class FinishLevel : MonoBehaviour
{
    // Store the current level's bgm.
    public GameObject levelMusic;
    // Store the level complete music.
    public AudioSource levelComplete;
    // Store the global timer.
    public GameObject levelTimer;

    // Store three GameObjects which holds info about time left, current score and the total score.
    public GameObject timeLeft;
    public GameObject currScore;
    public GameObject totalScore;

    // Store the level obstacle object (which controls four obstacles around the character).
    public GameObject levelObstacles;

    // Store the fade out object
    public GameObject fadeOut;
    
    // Store the score earned by the time left.
    private int timeScore;
    // Store the score earned by gems.
    private int gemScore;
    // Store the final total score.
    private int finalScore;

    // When play reach the exit, stop the current level's music and timer and then play level complete music.
    private void OnTriggerEnter()
    {
        // Disabled the box collider above the exit to avoid completing game again and again.
        GetComponent<BoxCollider>().enabled = false;
        
        // Activate obstacles.
        levelObstacles.SetActive(true);
        // Detach obstacles from the character to freeze the character.
        levelObstacles.transform.parent = null;
        
        // Get the time score by left time multiplies 100.
        timeScore = GlobalTimer.extendScore * 100;
        
        // Display the left time score earned by gems.
        timeLeft.GetComponent<Text>().text = "Time Left: " + timeScore / 100 + " x 100";
        currScore.GetComponent<Text>().text = "Score: " + GlobalScore.currScore;
        // Store the final total score.
        finalScore = GlobalScore.currScore + timeScore;
        // Display the final total score
        totalScore.GetComponent<Text>().text = "Total Score: " + finalScore;
        
        // Store total score by PlayerPrefs.
        PlayerPrefs.SetInt("LevelScore", finalScore);
        
        // Stop playing the current level's music.
        levelMusic.SetActive(false);
        // Stop the current level's timer.
        levelTimer.SetActive(false);
        // Play the level complete music.
        levelComplete.Play();
        // Start the coroutine by calling the CalculateScore method.
        StartCoroutine(CalculateScore());
    }

    /**
     * When coroutine is started, calculate time left, current score,
     * total score and display them with short intervals.
     */
    private IEnumerator CalculateScore()
    {
        // Set time left to be true.
        timeLeft.SetActive(true);
        // Wait for 0.5 seconds.
        yield return new WaitForSeconds(0.5f);
        // Set current score to be true.
        currScore.SetActive(true);
        // Wait for 1 second.
        yield return new WaitForSeconds(1);
        // Set total score to be true.
        totalScore.SetActive(true);
        // Wait for 1 second.
        yield return new WaitForSeconds(1);
        // Activate the fade out object and let it display fade out effect.
        fadeOut.SetActive(true);
    }
}
