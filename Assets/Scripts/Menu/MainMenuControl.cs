using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{

    public string GameSceneName;

    public void StartGame()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
