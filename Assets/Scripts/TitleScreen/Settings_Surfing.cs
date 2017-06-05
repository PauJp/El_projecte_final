using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings_Surfing : MonoBehaviour {

    public GameObject videoPanel;
    public GameObject audioPanel;
    public GameObject controllerPanel;


    public void ShowVideoPanel()
    {
        videoPanel.SetActive(true);
        audioPanel.SetActive(false);
        controllerPanel.SetActive(false);

    }

    public void ShowAudioPanel()
    {
        videoPanel.SetActive(false);
        audioPanel.SetActive(true);
        controllerPanel.SetActive(false);

    }

    public void ShowControllerPanel()
    {
        videoPanel.SetActive(false);
        audioPanel.SetActive(false);
        controllerPanel.SetActive(true);

    }
}
