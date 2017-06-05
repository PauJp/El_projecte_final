using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Surfing : MonoBehaviour
{
    public GameObject main;
    public GameObject settings;
 


	public void ShowMain()
    {
        main.SetActive(true);
        settings.SetActive(false);

    }

    public void ShowSettings()
    {
        main.SetActive(false);
        settings.SetActive(true);

    }

   
}
