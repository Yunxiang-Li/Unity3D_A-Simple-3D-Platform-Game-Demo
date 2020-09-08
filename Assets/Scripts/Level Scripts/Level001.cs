using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class represents all behaviours of setting next load level to be the level 001.
 */
public class Level001 : MonoBehaviour
{
    // Store the fade in game object.
    public GameObject fadeIn;
    // Start is called before the first frame update
    private void Start()
    {
        // Set the next load level to be level001.
        LevelLoad.levelToGo = 2;
        // Call FadeInOff method as coroutine.
        StartCoroutine(FadeInOff());
    }
    
    /**
     * Deactivate the fade in object after fade in effect being displayed.
     */
    private IEnumerator FadeInOff()
    {    
        // Wait for one second (let fade in object display fade in effect).
        yield return new WaitForSeconds(1);
        // Deactivate the fadeIn object.
        fadeIn.SetActive(false);
    }
}
