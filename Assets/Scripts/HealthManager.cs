using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public int maxPlayerHealth;
    public static int Health;

    //Text text;
    public Slider healthBar;

    private LevelManager levelManager;

    public bool isDead;

	// Use this for initialization
	void Start () {

        healthBar = GetComponent<Slider>();
        //text = GetComponent<Text>();

        Health = maxPlayerHealth;

        levelManager = FindObjectOfType<LevelManager>();
        isDead = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Health <= 0 && !isDead)
        {
            levelManager.RespawnPlayer();
            isDead = true;

        }
        //text.text = "" + Health;
        healthBar.value = Health;
	}

    public static void HurtPlayer(int damageToGive)
    {
        Health -= damageToGive;
    }

    public void FullHealth()
    {
        Health = maxPlayerHealth;
    }
}
