using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public static int levelToGo;

    // Update is called once per frame
    private void Update()
    {
        if (levelToGo == 2)
            SceneManager.LoadScene(levelToGo);

    }
}
