﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaincamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 1 * Time.deltaTime, 0f);
    }
}
