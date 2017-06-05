using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSurfing : MonoBehaviour {

    public GameObject main;
    public GameObject settings;

    public void ShowMain()
    {
        main.SetActive(true);
        settings.SetActive(false);

    }

    public void ShowSettings()
    {
        settings.SetActive(true);
        main.SetActive(false);

    }

    public void ExitGame()
    {

        Application.Quit();

    }
}
