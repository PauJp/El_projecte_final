using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParticleControl : MonoBehaviour {

    public float speed;

    public PlayerController player;

    public GameObject enemydeadEffect;

    public int DamageToGive;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if (player.transform.localScale.x < 0)
            speed = -speed;
        
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            /*Destroy(collision.gameObject);
            Instantiate(enemydeadEffect, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);*/
            collision.GetComponent<EnemyHealthManager>().givedamage(DamageToGive);


        }
        if(collision.tag == "Land")
        {
            Destroy(gameObject);
        }
        if(collision.tag == "Boss")
        {
            collision.GetComponent<BossHealthManager>().givedamage(DamageToGive);
        }

    }
}
