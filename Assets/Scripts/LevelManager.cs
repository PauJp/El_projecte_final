using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject Spawnpoint;

    private PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        Debug.Log("PlayerRespawn");
        player.transform.position = Spawnpoint.transform.position;
    }
}
