using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This class represents all behaviour a death zone object should have.
 */
public class DeathZone : MonoBehaviour
{
    // Store the fade out object, fell message object and the level music object.
    public GameObject FadeOutObject;
    public GameObject FellMsgObject;
    public GameObject LevelMusic;
    
    // When the player drops and triggers with the death zone, start the coroutine of FellToDeath method.
    private void OnTriggerEnter()
    {
        StartCoroutine(FellToDeath());
    }

    /**
     * When the player drop to the death zone, call this method.
     */
    private IEnumerator FellToDeath()
    {
        // Set FellMsgObject to be active.
        FellMsgObject.SetActive(true);
        // Stop the current level's music since the player was already dead.
        LevelMusic.SetActive(false);
        // Wait for 1 second.
        yield return new WaitForSeconds(1);
        // Set FadeOutObject to be true.
        FadeOutObject.SetActive(true);
        // Wait for 1 second.
        yield return new WaitForSeconds(1);
        // Reset player's score to 0 if the player dead.
        GlobalScore.currScore = 0;
        // Load the "3" scene(the redirect scene).
        SceneManager.LoadScene(3);
    }
}
