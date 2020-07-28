using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string gameOverSceneName;
    public string menuSceneName;
    public string gameSceneName;
    public string creditsSceneName;
    public string helpSceneName;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuSceneName);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(menuSceneName); 
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditsSceneName);
    }

    public void Help()
    {
        SceneManager.LoadScene(helpSceneName);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(gameOverSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }








}