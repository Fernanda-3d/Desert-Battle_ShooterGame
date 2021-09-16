using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] float loadDelay = 1.0f;
    [SerializeField] AudioSource clickSound;
    
   void Start()
   {
       pauseMenu.SetActive(false);
   }
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
             if(isGamePaused)
        {
            Resume();
        } 
        else
        {
            Pause();
        }

        }
       
    }

    public void Resume()
    {
        clickSound.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    
    public void Pause()
    {
        clickSound.Play();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu()
    {
        clickSound.Play();
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
