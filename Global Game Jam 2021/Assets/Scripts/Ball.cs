using System.Collections;
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
    public ParticleSystem ps;

    private Gradient grad;

    void Start()
    {
        ballLight = GetComponent<Light>();
        ballRenderer = GetComponent<MeshRenderer>();
        var col = ps.colorOverLifetime;
        grad = new Gradient();
    }

    private void RedBall()
    {
        ballLight.color = Color.red;
        ballRenderer.material.SetColor("_EmissionColor", Color.red);

        grad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.red, 0.5f), new GradientColorKey(Color.red, 1f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.7f), new GradientAlphaKey(0.0f, 1.0f) });

        // col.color = grad;
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
