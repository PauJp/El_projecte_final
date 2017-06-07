using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject Spawnpoint;

    private PlayerController player;

    public GameObject deadParticle;
    public GameObject respawnParticle;

    public float respawndelay;

    public HealthManager healthManager;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        healthManager = FindObjectOfType<HealthManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        StartCoroutine("PlayerRes");
    }

    public IEnumerator PlayerRes()
    {
        Instantiate(deadParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        Debug.Log("PlayerRespawn");
        yield return new WaitForSeconds(respawndelay);
        player.transform.position = Spawnpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        healthManager.FullHealth();
        healthManager.isDead = false;
        Instantiate(respawnParticle, Spawnpoint.transform.position, Spawnpoint.transform.rotation);

    }
}
