using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioSelection : MonoBehaviour
{
   private GameObject[] audioList;
   private int index;
    void Start()
    {
        index = PlayerPrefs.GetInt("AudioSelected");

        audioList = new GameObject[transform.childCount];

        //Fill the array with the audio
        for(int i = 0; i < transform.childCount; i++)
        {
            audioList[i] = transform.GetChild(i).gameObject;
        }

        //Toggle them off
        foreach(GameObject go in audioList)
        {
            go.SetActive(false);
        }

        //Toggle On the selected audio
        if(audioList[index])
        audioList[index].SetActive(true);
    }

    public void ToggleLeft()
    { 
        // Toggle Off the current audio
        audioList[index].SetActive(false);

        index--;
        if(index < 0)
        index = audioList.Length -1;

        // Toggle On the new audio
        audioList[index].SetActive(true);

    }

     public void ToggleRight()
    { 
        // Toggle Off the current audio
        audioList[index].SetActive(false);

        index++;
        if(index == audioList.Length)
        index = 0;

        // Toggle On the new audio
        audioList[index].SetActive(true);

    }

    public void Confirm()
    {
        PlayerPrefs.SetInt("AudioSelected", index);
        SceneManager.LoadScene("Texas");
    }


   
}
