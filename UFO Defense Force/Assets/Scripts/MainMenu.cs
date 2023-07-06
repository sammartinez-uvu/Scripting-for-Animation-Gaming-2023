using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    //custom StartGame void other scripts can access
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame() { 
        
        Application.Quit();
        Debug.Log("Quit Game!");
    }

}