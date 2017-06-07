using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyHeath;
    public GameObject deadEffect;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (enemyHeath <= 0)
        {
            Instantiate(deadEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
    public void givedamage(int damageToGive)
    {
        enemyHeath -= damageToGive;
    }
}
