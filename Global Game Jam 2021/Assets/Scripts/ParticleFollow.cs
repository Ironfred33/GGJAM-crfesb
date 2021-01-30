using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public GameObject ball;
    public Vector3 destination;
    public float waitTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destination = ball.transform.position;
        StartCoroutine(MoveParticles());
    }

    private IEnumerator MoveParticles()
    {
        yield return new WaitForSeconds(waitTime);
        transform.position = destination;
        yield return null;

    }
}
