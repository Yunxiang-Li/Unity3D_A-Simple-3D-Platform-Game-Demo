using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class represents all behaviour of rotating skybox.
 */
public class SkyRotate : MonoBehaviour
{
    // Set rotate speed to 1.2.
    private float rotateSpeed = 1.2f;

    // Update is called once per frame
    private void Update()
    {
        // Let skybox rotate with certain rotate speed.
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
