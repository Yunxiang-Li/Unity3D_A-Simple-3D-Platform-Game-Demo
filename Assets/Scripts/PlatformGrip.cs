using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class represents all behaviour a platform grip object should have.
 */
public class PlatformGrip : MonoBehaviour
{
    // Store the entity of grip and the player.
    public GameObject theLedge;
    public GameObject thePlayer;

    // When the player is in the grip area, set player's transform as grip entity's transform's child.
    // (Let the player move with the same pace as the moving platform)
    private void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    // When the player is out of the grip area, set player's transform's parent to null.
    // (player's pace wont be affected by the platform anymore)
    private void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }
}
