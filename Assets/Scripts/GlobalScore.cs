using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public Text scoreText;
    public static int currScore;
    private int internalScore;
        
    // Update is called once per frame
    private void Update()
    {
        internalScore = currScore;
        // Increase the current score by 1000;
        scoreText.text = internalScore.ToString();
    }
}
