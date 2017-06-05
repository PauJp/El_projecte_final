using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iguana_Range : MonoBehaviour
{

    public Transform Iguana;

    private Collider2D colliderRB;


    public GameObject Projectile;
    public Transform shootFrom;
    public int chanceShoot;
    public float TDestroy;
    //public GameObject ColliderRang;

    public GameObject iguana;

    //private SpriteRenderer spriteRenderer;

    //public Transform bulletPrefab;

    public float nextShootT;

    public float delay;
    public float weaponSpeed;
    public GameObject player;
    private Rigidbody2D coll_particle;
    public float projectille_speed;

    //bool shoot;

    // Use this for initialization
    void Start()
    {
        colliderRB = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        colliderRB.transform.position = Iguana.position;

    }
    private void OnTriggerStay2D(Collider2D collision)   // Trigger Shoot
    {
        if (collision.tag == "Player" && nextShootT < Time.time)
        {
            nextShootT = Time.time * nextShootT;
            if (Random.Range(0, 10) >= chanceShoot)
            {
                var clonedProj = Instantiate(Projectile, shootFrom.position, Quaternion.identity);
                Destroy(clonedProj, TDestroy);
                Physics2D.IgnoreCollision(clonedProj.GetComponent<Collider2D>(), iguana.GetComponent<Collider2D>());
                
            }
           /* var clonedProj = Instantiate(Projectile, shootFrom.position, Quaternion.identity);
            coll_particle = clonedProj.GetComponent<Rigidbody2D>();
            coll_particle.velocity = (player.transform.position - transform.position).normalized * projectille_speed;

            Physics2D.IgnoreCollision(clonedProj.GetComponent<Collider2D>(), iguana.GetComponent<Collider2D>());
            
            Destroy(clonedProj, TDestroy);*/

        }
    }

}

