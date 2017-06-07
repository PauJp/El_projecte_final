using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shoot_control : MonoBehaviour {

    public float speed;
    public PlayerController player;
    private Rigidbody2D myRigidbody2d;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        myRigidbody2d = GetComponent <Rigidbody2D>();

        if(player.transform.position.x > transform.position.x)
        {
            speed = -speed;

        }
		
	}
	
	// Update is called once per frame
	void Update () {
        myRigidbody2d.velocity = -new Vector2(speed, myRigidbody2d.velocity.y);
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Jugador")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Land")
        {
            Destroy(gameObject);
        }
    }
}
