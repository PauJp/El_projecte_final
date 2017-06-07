using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public bool isPaused;
    public GameObject pauseMenu;

    void Update()
    {
        if (isPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene("ELJUEGO", LoadSceneMode.Single);
    }
    public void RetMain()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }
}

