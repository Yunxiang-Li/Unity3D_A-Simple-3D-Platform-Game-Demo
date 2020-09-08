using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class represents rotation of the gem.
 */
public class GemRotate : MonoBehaviour
{
    // Set rotation speed to 2.
    public int rotateSpeed = 2;

    // Update is called once per frame
    private void Update()
    {
        // Let the gem object rotates relative to the world around the global axis with certain rotate speed.
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
    }
}
