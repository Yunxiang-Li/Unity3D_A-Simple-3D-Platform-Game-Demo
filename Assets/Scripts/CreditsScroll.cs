using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This class represents all behaviours in the credits scene.
 */
public class CreditsScroll : MonoBehaviour
{
    // Store the credits object
    public GameObject creditsObject;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Call RollCredits method as coroutine.
        StartCoroutine(RollCredits());
    }

    /**
     * Help credits objects perform scroll effects.
     */
    private IEnumerator RollCredits()
    {
        // Wait for 0.5 seconds.
        yield return new WaitForSeconds(0.5f);
        // Set credit object to be true(Ready to be displayed).
        creditsObject.SetActive(true);
        // Wait for another 15 seconds to let credits objects perform scroll effects
        yield return new WaitForSeconds(15);
        // Load back to main menu scene.
        SceneManager.LoadScene(1);
    }
}
