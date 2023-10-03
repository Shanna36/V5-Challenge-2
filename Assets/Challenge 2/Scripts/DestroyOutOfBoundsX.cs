﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -41.0f;
    private float bottomLimit = -5.0f;

    // Update is called once per frame 
    void Update()
    {
        // Destroy dogs if z position less than left limit
        if (transform.position.z < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
