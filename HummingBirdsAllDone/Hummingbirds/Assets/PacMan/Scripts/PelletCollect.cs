﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletCollect : MonoBehaviour
{
    public int collected = 0;
    [SerializeField]


    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            collected++;
        }
     
    }
}
