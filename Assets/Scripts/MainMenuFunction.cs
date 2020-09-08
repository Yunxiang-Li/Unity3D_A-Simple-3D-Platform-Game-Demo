using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * This class represents all behaviours when user press three buttons in the main scene.
 */
public class MainMenuFunction : MonoBehaviour
{
    // Store the click music.
    public AudioSource clickMusic;

    // Store the best score and its Text object.
    private int bestScore;
    public Text bestScoreText;

    /**
     * Get best score from PlayerPrefs and display it in the main menu scene.
     */
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreText.text = "Best : " + bestScore;
    }

    /**
     * After player press the Play button, play the click music and load the level one scene.
     */
    public void PlayGame()
    {
        // Play the click music.
        clickMusic.Play();
        // Set redirect scene 's next load level to be 2(The level one scene). 
        LevelLoad.levelToGo = 2;
        // Load the 3 scene(the redirect scene).
        SceneManager.LoadScene(3);
    }

    /**
     * After the player press the Quit button, quit the game.
     */
    public void QuitGame()
    {
        // Play the click music.
        clickMusic.Play();
        Application.Quit();
    }

    /**
     * After the player press the View Credits button, load the Credits scene.
     */
    public void DisplayCredits()
    {
        // Play the click music.
        clickMusic.Play();
        SceneManager.LoadScene(4);
    }

    /**
     * After the player press the Reset button, reset level's best score back to 0.
     */
    public void ResetBestScore()
    {
        // Reset best score by PlayerPrefs.
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}
