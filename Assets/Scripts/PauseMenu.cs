using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
   
    string LandingScene = "Landing Scene";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }
        }
               
    }

    //A call to resume a PAUSED screen
    private void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    //A call to pause a LIVE screen
    private void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    
    //A call to RESTART game from the LANDING Scene
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LandingScene);

    }
    
    // To Quit Game 
    public void QuitGame()
    {
        Application.Quit();
        
    }
    
   
}
