using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject settings;

    public void NewGame()
    {
        SceneManager.LoadScene("ELJUEGO", LoadSceneMode.Single);
    }

    public void Settings()
    {
        settings.SetActive(true);

    }

    public void Exit()
    {
        Application.Quit();

    }
}
