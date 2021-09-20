using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour
{
    float delay = 3f;
    float timeElapsed;
    public GameObject gameOverPanel;
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delay)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
