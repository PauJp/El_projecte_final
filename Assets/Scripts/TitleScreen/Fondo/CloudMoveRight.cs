using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveRight : MonoBehaviour {
    public float smoothTime = 20.0f;
    private Vector3 smoothVelocity = Vector3.zero;
    public Vector3 lastPosition;

    // Use this for initialization
    void Start () {
        lastPosition = new Vector3(100, 25, 0);
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x > 84)
        {
            transform.position = new Vector3(0,transform.position.y,transform.position.z);
        }

        transform.position = Vector3.SmoothDamp(transform.position, lastPosition, ref smoothVelocity, smoothTime);
		
	}
}
