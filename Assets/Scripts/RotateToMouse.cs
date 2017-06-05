﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class RotateToMouse : MonoBehaviour
{
    public float offset = 0.0f;


    private SpriteRenderer spriteRenderer;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);

        if (rotation_z >= 180 || rotation_z <= 360)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

    }
}