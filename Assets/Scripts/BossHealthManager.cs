using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthManager : MonoBehaviour
{

    public int enemyHeath;
    public GameObject deadEffect;
    public GameObject bossPrefab;
    public float minSize;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHeath <= 0)
        {
            Instantiate(deadEffect, transform.position, transform.rotation);

            if(transform.localScale.y > minSize)
            {
                GameObject clone1 = Instantiate(bossPrefab, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z),transform.rotation) as GameObject;
                GameObject clone2 = Instantiate(bossPrefab, new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z),transform.rotation) as GameObject;

                clone1.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone1.GetComponent<BossHealthManager>().enemyHeath = 10;

                clone2.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone2.GetComponent<BossHealthManager>().enemyHeath = 10;

            }
            Destroy(gameObject);
        }

    }
    public void givedamage(int damageToGive)
    {
        enemyHeath -= damageToGive;
    }
}
