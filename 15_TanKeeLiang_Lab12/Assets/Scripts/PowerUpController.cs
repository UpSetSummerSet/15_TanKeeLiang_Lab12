﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public float spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //rotateSpeed = Random.Range(60.0f, 90.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0,0));
    }
}
