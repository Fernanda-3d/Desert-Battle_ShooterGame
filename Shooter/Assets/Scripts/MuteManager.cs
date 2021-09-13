using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MuteManager : MonoBehaviour
{
    private bool muted = false;
    
    public Image soundOn;
    public Image soundOff;
    public GameObject pausePanel;

    /*[SerializeField] float levelLoadDelay = 1.0f;
    public AudioClip play;
    public AudioClip quit; */


    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
        
       // AudioListener.pause = isMuted;
       if(!PlayerPrefs.HasKey("muted"))
       {
           PlayerPrefs.SetInt("muted", 0);
           Load();
       }
       else
       {
           Load();
       }
      
       UpdateButtonIcon();
       AudioListener.pause = muted;
       
        
    }

    public void OnButtonPress()
    {
       // isMuted = !isMuted;
       if (muted == false)
       {
           muted = true;
           AudioListener.pause = true;
       }
       else 
       {
           muted = false;
           AudioListener.pause = false;
            
       }

       Save();   
       UpdateButtonIcon(); 

        
    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOn.enabled = true;
            soundOff.enabled = false;
        }
        else
        {
            soundOn.enabled = false;
            soundOff.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
        

    }

    private void Save()
    {
         PlayerPrefs.SetInt("muted", muted ? 1 : 0);

    }

    /*public void PressPlay()
    {
    audioSource.PlayOneShot(play);
    Invoke ("LoadNextLevel", levelLoadDelay);
    } */

    /*public void PressQuit()
    {
    audioSource.PlayOneShot(quit);
    Invoke ("QuitGame", levelLoadDelay);
    } */

    public void PauseButtom()
    {
       pausePanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

     public void Play()
    {
        SceneManager.LoadScene("Menu");
    }

   
}
