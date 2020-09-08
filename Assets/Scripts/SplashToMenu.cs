using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This class represents all behaviour of changing from intro scene to main menu scene.
 */
public class SplashToMenu : MonoBehaviour
{
    // Store the Intro object.
    public GameObject IntroObject;
    // Start is called before the first frame update
    private void Start()
    {
        // Call RunSplash method as routine.
        StartCoroutine(RunSplash());
    }

    /**
     * 
     */
    private IEnumerator RunSplash()
    {
        // First wait for half seconds.
        yield return new WaitForSeconds(0.5f);
        // Then set intro object to be active(display the intro message).
        IntroObject.SetActive(true);
        // Wait for 4.5 seconds(let the intro message display all visual effects).
        yield return new WaitForSeconds(4.5f);
        // Load the main menu scene.
        SceneManager.LoadScene(1);
    }
}
