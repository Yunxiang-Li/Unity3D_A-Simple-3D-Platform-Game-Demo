using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This class represents all behaviour of green gem object.
 */
public class GemGreen : MonoBehaviour
{
    // Store the collectSound.
    public AudioSource collectSound;

    /**
     * When the green gem object collides with something(in this game only the player), destroy the game object,
     * add 1000 score to the player's current score and play the collect sound.
     */
    private void OnTriggerEnter()
    {
        GlobalScore.currScore += 1000;
        // Play the collect sound.
        collectSound.Play();
        // Destroy the silver gem object.
        Destroy(gameObject);
    }
}
