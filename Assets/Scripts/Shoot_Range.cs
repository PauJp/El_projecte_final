using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Range : MonoBehaviour {

    public float playerRange;
    public GameObject enemyProj;
    public PlayerController player;
    public Transform launchPoint;

    public float waitBetreenShots;
    private float shotCounter;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        shotCounter = waitBetreenShots;
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));

        shotCounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            Instantiate(enemyProj, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetreenShots;
        }

        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            Instantiate(enemyProj, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetreenShots;
        }

    }
}
