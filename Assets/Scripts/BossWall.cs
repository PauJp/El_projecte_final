using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWall : MonoBehaviour {
    /*Crear una paret amb un unic collider */
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(FindObjectOfType<BossHealthManager>())
        {
            return;
        }
        Destroy(gameObject);
 
		
	}
}
