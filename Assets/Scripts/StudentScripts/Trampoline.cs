﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    [SerializeField] ParticleSystem pSystem;
    [SerializeField] GameManager scoreScript;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            scoreScript.score++;
            //Particle effect
            pSystem.Play();
        }
    }
}
