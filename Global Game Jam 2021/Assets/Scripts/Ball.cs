﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ballState
{
    blue, 
    yellow,
    red
}

public class Ball : MonoBehaviour
{
    public ballState currentState;
    private Light ballLight;
    private MeshRenderer ballRenderer;


    void Start()
    {
        ballLight = GetComponent<Light>();
        ballRenderer = GetComponent<MeshRenderer>();
     
    }

    private void RedBall()
    {
        ballLight.color = Color.red;
        ballRenderer.material.SetColor("_EmissionColor", Color.red);
    }

    private void BlueBall()
    {
        ballLight.color = Color.blue;
        ballRenderer.material.SetColor("_EmissionColor", Color.blue);
    }


    void Update()
    {
        if(currentState == ballState.red)
        {
            RedBall();
        }

        else if(currentState == ballState.blue)
        {
            BlueBall();
        }
    }
}
