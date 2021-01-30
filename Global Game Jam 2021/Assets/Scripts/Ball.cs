using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ballState
{
    blue, 
    green,
    red
}

public class Ball : MonoBehaviour
{
    public ballState currentState;
    private Light ballLight;
    private MeshRenderer ballRenderer;
    private bool destroyEnemy;


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

    private void GreenBall()
    {
        ballLight.color = Color.green;
        ballRenderer.material.SetColor("_EmissionColor", Color.green);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && currentState == ballState.green)
        {
            Object.Destroy(collision.gameObject);
        }
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

        else if(currentState == ballState.green)
        {
            GreenBall();
        }
    }
}
