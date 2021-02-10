﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControlloer : MonoBehaviour
{
    // Start is called before the first frame update

    private float rotSpeed = 0.5f;
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
