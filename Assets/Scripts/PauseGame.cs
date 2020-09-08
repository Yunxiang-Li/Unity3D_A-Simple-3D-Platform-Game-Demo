using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This class represents all behaviour of pausing the game.
 */
public class PauseGame : MonoBehaviour
{
    // Initialize the flag to be false.
    private bool gamePaused = false;
    // Store the level music.
    public AudioSource levelMusic;
    // Store the pause menu.
    public GameObject pauseMenu;
    // Store the pause music.
    public AudioSource pauseJingle;
    
    // Update is called once per frame
    private void Update()
    {
        // If the player does not press the cancel button(ESC) then do nothing.
        if (!Input.GetButtonDown("Cancel"))
            return;
        // From normal playing to pause state.
        if (gamePaused == false)
        {
            // Play the pause music
            pauseJingle.Play();
            // Set time scale to zero to freeze the game.
            Time.timeScale = 0;
            // Change flag to true.
            gamePaused = true;
            // let cursor be visible.
            Cursor.visible = true;
            // Stop playing the level music.
            levelMusic.Pause();
            // Activate the pause menu
            pauseMenu.SetActive(true);
        }
        // From pause state to normal playing.
        else
        {
            // Set time scale to one to activate the game.
            Time.timeScale = 1;
            // Change flag to false.
            gamePaused = false;
            // let cursor be invisible.
            Cursor.visible = false;
            // Start playing the level music.
            levelMusic.Play();
            // Deactivate the pause menu
            pauseMenu.SetActive(false);
        }
    }

    /**
     * When the player pause the game and press the resume button, resume playing game.
     */
    public void ResumeGame()
    {
        // Set time scale to one to activate the game.
        Time.timeScale = 1;
        // Change flag to false.
        gamePaused = false;
        // let cursor be invisible.
        Cursor.visible = false;
        // Start playing the level music.
        levelMusic.Play();
        // Deactivate the pause menu
        pauseMenu.SetActive(false);
    }

    /**
     * When the player pause the game and press restart button, restart the current level.
     */
    public void RestartLevel()
    {
        // Set time scale to one to activate the game.
        Time.timeScale = 1;
        // Change flag to false.
        gamePaused = false;
        // let cursor be invisible.
        Cursor.visible = false;
        // Start playing the level music.
        levelMusic.Play();
        // Deactivate the pause menu
        pauseMenu.SetActive(false);
        
        // Load redirect scene to restart the current level.
        SceneManager.LoadScene(3);
    }

    public void QuitToMenu()
    {
        // Set time scale to one to activate the game.
        Time.timeScale = 1;
        // Change flag to false.
        gamePaused = false;
        // let cursor be visible.
        Cursor.visible = true;
        // Start playing the level music.
        levelMusic.Play();
        // Deactivate the pause menu
        pauseMenu.SetActive(false);
        
        // Load redirect scene to restart the current level.
        SceneManager.LoadScene(1);
    }
}
