using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedParticles : MonoBehaviour
{
    public ParticleSystem ps;

    private Gradient redGrad;

    void Start()
    {
        var col = ps.colorOverLifetime;
        col.enabled = true;

        redGrad = new Gradient();
        redGrad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.red, 0.5f), new GradientColorKey(Color.red, 1f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.7f), new GradientAlphaKey(0.0f, 1.0f) });
        col.color = redGrad;
    }

}
