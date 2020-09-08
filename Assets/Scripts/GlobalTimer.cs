using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This class represents all behaviours of global game times.
 */
public class GlobalTimer : MonoBehaviour
{
    // Store two timers in the top right corner.
    public Text timeTextSmall;
    public Text timeTextBig;

    // Initialize the flag to false and the start time to 150 seconds.
    private bool isTakingTime = false;
    private int currSeconds = 150;

    // Store the extend score.
    public static int extendScore;

    // Update is called once per frame
    private void Update()
    {
        // Set extend score to be time left.
        extendScore = currSeconds;
        // If the flag is false, call the SubtractSecond function.
        if (!isTakingTime)
            StartCoroutine(SubtractSecond());
    }

    /**
     * Subtract one second from two timers, display them and wait for 1 second in each coroutine.
     */
    private IEnumerator SubtractSecond()
    {
        // Set flag to be true so that we wont call this function until next coroutine.
        isTakingTime = true;
        // Minus current time by one second.
        currSeconds--;
        
        // Display the new time in two timers.
        timeTextSmall.text = currSeconds.ToString();
        timeTextBig.text = currSeconds.ToString();
        
        // Wait for 1 second (since we minus one second)
        yield return new WaitForSeconds(1);
        
        // Set flag to false again so this function will do same thing in next coroutine.
        isTakingTime = false;
    }
}
