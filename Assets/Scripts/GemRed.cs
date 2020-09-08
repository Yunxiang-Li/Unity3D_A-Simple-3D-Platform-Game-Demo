using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class represents all behaviour of red gem object.
 */
public class GemRed : MonoBehaviour
{
    // Store the collectSound.
    public AudioSource collectSound;

    /**
     * When the red gem object collides with something(in this game only the player), destroy the game object,
     * add 1500 score to the player's current score and play the collect sound.
     */
    private void OnTriggerEnter()
    {
        GlobalScore.currScore += 1500;
        // Play the collect sound.
        collectSound.Play();
        // Destroy the silver gem object.
        Destroy(gameObject);
    }
}
